using System.Collections.Generic;

namespace IdentityServer.Models.ViewModels {

    public class ProfileViewModel {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public List<string> Roles
        {
            get; set;
        }
        public ApplicationUser AppUser { get; set; }
        public ProfileViewModel()
        { }

        public ProfileViewModel(ApplicationUser user)
        {
            AppUser = user;
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            FullName = $"{user.FirstName} {user.LastName}";
            Roles = new List<string>();
        }

        public static IEnumerable<ProfileViewModel> GetUserProfiles(IEnumerable<ApplicationUser> users)
        {
            var profiles = new List<ProfileViewModel> { };
            foreach (ApplicationUser user in users)
            {
                profiles.Add(new ProfileViewModel(user));
            }

            return profiles;
        }
    }
}
