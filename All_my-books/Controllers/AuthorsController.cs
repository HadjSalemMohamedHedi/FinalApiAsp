using All_my_books.Data.Services;
using All_my_books.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace All_my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        public readonly AuthorsService _authorService;
        public AuthorsController(AuthorsService AuthorService)
        {
            _authorService = AuthorService;
        }


        [HttpPost]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorService.AddAuthor(author);
            return Ok("Author Added with success !!! ");
        }

        
        [HttpGet("GetAuthorswithBookds/{authorId}")]
        public IActionResult GetAuthorswithBookds([FromRoute] int authorId)
        {
            var response = _authorService.GetAuthorswithBookds(authorId);
            return Ok(response);
        }
        

    }
}
