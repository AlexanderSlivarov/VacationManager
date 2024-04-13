using System.Collections;

namespace VacationManager.Models.User
{
    public class UserDetailsViewModel : UserViewModel
    {
        public string FirstName { get; init; } = null!;
        public string LastName { get; init; } = null!;        
    }
}
