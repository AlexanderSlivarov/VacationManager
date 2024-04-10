using Microsoft.AspNetCore.Identity;

namespace VacationManager.Data
{
    public class ApplicationUser : IdentityUser
    {        
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string TeamName { get; set; } = null!;
    }
}
