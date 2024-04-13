using Microsoft.AspNetCore.Identity;
using VacationManager.Data.Models;

namespace VacationManager.Data
{
    public class ApplicationUser : IdentityUser
    {        
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;         

        public string Role { get; set; } = null!;
    }
}
