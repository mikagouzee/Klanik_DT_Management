using Klanik_Internal.Models;
using Klanik_Internal.Models.ViewModels;
using Klanik_Internal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecruiterController : Controller
    {
        private readonly IService<Konsultant> _konsultantService;
        private readonly IService<Recruiter> _recruiterService;

        public RecruiterController(IService<Konsultant> konsultantService, IService<Recruiter> recruiterService)
        {
            _konsultantService = konsultantService;
            _recruiterService = recruiterService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetTest()
        {
            return Ok("Test");
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost("UpdatePortfolio")]
        public IActionResult UpdatePortfolio([FromBody]RecruiterUpdateModel model)
        {


            var recruiter = _recruiterService.GetById(model.Id);

            var RemovedFromPortfolio = recruiter.Portfolio
                .Select(x => x.Id)
                .Except(model.Konsultants.Select(y => Guid.Parse(y)))
                .ToList();

            foreach (var id in model.Konsultants)
            {
                if(!recruiter.Portfolio.Any(x => x.Id == Guid.Parse(id)))
                {
                    var kons = _konsultantService.GetById(Guid.Parse(id));
                    recruiter.Portfolio.Add(kons);
                }
            }

            foreach (var id in RemovedFromPortfolio)
            {
                if(recruiter.Portfolio.Any(x => x.Id == id))
                {
                    recruiter.Portfolio.Remove(recruiter.Portfolio.FirstOrDefault(x => x.Id == id));
                }
            }

            _recruiterService.Update(recruiter);

                    

            return Ok();
        }
    }
}
