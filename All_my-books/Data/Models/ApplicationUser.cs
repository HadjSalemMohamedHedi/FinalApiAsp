using Microsoft.AspNetCore.Identity;

namespace All_my_books.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
