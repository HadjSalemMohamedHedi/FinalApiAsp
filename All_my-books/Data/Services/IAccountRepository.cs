using All_my_books.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;


namespace All_my_books.Data.Services
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);

    }
}
