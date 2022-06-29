using All_my_books.Data.Models;
using All_my_books.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace All_my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }



        [HttpPost("signUp")]
        public async Task<IActionResult> signUp([FromBody] SignUpModel signUpModel)
        {
            var result = await _accountRepository.SignUpAsync(signUpModel);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] SignInModel SignInModel)
        {
            var result = await _accountRepository.LoginAsync(SignInModel);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }

    }
}
