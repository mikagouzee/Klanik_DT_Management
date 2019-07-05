using IdentityServer.Models;
using IdentityServer.Models.MailSender;
using IdentityServer.Models.ViewModels;
using IdentityServer.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace IdentityServer.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _mailSender;
        private FrontConfig _options { get; set; }

        private readonly IUserRepository _userRepository;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IEmailSender emailSender,
            IOptions<FrontConfig> options,
            IUserRepository userRepository
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mailSender = emailSender;
            _options = options.Value;
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser { UserName = model.UserName, FirstName = model.FirstName, LastName = model.LastName, Email = model.Email };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                #region confirm email
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                //var url = "https://localhost:44363/api/account/confirm/";

                var callbackUrl = Url.Action("Confirm",
                    "Account",
                    values: new { userId = user.Id, code = code },
                    protocol: Request.Scheme);

                await _mailSender.SendEmailAsync(model.Email, "Confirm your email!", $"Please confirm your account by" +
                    $" <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'> clicking here</a>.");
                #endregion

                #region set up basic user role for user and create profile claims
                string role = "Basic User";


                if (await _roleManager.FindByNameAsync(role) == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }

                await _userManager.AddToRoleAsync(user, role);

                await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("userName", user.UserName));
                await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("firstName", user.FirstName));
                await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("lastName", user.LastName));
                await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("email", user.Email));
                await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("role", role));
                #endregion

                //return Ok(new ProfileViewModel(user));
                return Ok();
            }

            return BadRequest(result.Errors);

        }

        [HttpPost("SetRole/{userId}/{role}")]
        public async Task<IActionResult> SetRole(string userId, string role)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                if (await _roleManager.FindByNameAsync(role) == null)
                    await _roleManager.CreateAsync(new IdentityRole(role));

                await _userManager.AddToRoleAsync(user, role);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("Confirm")]
        public async Task<IActionResult> Confirm(string userId, string code)
        {
            if (userId == null || code == null)
                return BadRequest();

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"No user found with id {userId}.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Error confirming email for user id {userId}.");
            }

            var url = _options.FrontUrl;

            //HtmlString res = new HtmlString($"Thank you for confirming your email. <a href='{HtmlEncoder.Default.Encode(url)}'>Back to our site</a>.");

            return Redirect(url);

        }

        [HttpGet("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                return Ok();

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            code = Convert.ToBase64String(Encoding.Unicode.GetBytes(code));

            string callbackurl = Url.Action("ResetPassword",
                "Account",
                values: new
                {
                    UserId = user.Id,
                    code = code
                },
                protocol: Request.Scheme
               );

            await _mailSender.SendEmailAsync(email, "Someone requested to reset your password",
                $"If you requested to reset your password, please <a href='{HtmlEncoder.Default.Encode(callbackurl)}'>click here</a>. ");

            return Ok();
        }

        [HttpGet("ResetPassword")]
        public async Task<IActionResult> ResetPassword(string userId, string code)
        {
            if (userId == null || code == null)
                return BadRequest();

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return NotFound($"We could not found any user with id {userId}");


            var url = _options.FrontUrl + $"/reset?userid={userId}&code={code}";

            return Redirect(url);

        }

        [HttpPost("SaveNewPassword")]
        public async Task<IActionResult> SaveNewPassword([FromBody]NewPasswordModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null)
                return BadRequest();

            var code = Encoding.Unicode.GetString(Convert.FromBase64String(model.Code));

            var result = await _userManager.ResetPasswordAsync(user, code, model.NewPassword);


            if (result.Succeeded)
                return Ok();

            return BadRequest();
        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            var res = _userRepository.GetAllUsers();
            return Ok(res);
        }

        [HttpGet("roles")]
        public IActionResult GetAllRoles()
        {
            var result = _userRepository.GetAllRoles();
            return Ok(result);
        }

        [HttpPut("OptIn")]
        public async Task<IActionResult> OptIn([FromBody]OptInModel optInModel)
        {
            //Get the user 
            if (optInModel == null || optInModel.id == null)
                return BadRequest();
            var user = await _userManager.FindByIdAsync(optInModel.id.ToString());
            if (user == null)
                return NotFound($"We could not found any user with id {optInModel.id.ToString()}");
            //Change user OptIn 
            user.OptIn = optInModel?.optIn;
            await _userManager.UpdateAsync(user);
            return Ok();
        }

        [HttpGet("GetRecruteur/{id}")]
        public IActionResult GetRecruteur(Guid id)
        {
            return Ok(_userRepository.GetOne(id));
        }
    }
}