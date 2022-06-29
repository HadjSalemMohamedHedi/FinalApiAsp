using All_my_books.Data.Services;
using All_my_books.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace All_my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        public readonly BooksService _bookService;
        public BooksController(BooksService bookService)
        {
            _bookService = bookService;
        }



        [HttpPost("Add-Book")]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _bookService.AddBook(book);
            return Ok("Book Added With Success ! ");
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpGet("GetBookById/{IdBooktoGet}")]
        public IActionResult GetBookById([FromRoute] int IdBooktoGet)
        {
           var _book = _bookService.GetBookById(IdBooktoGet);
            if(_book == null)
            {
                return NotFound("Book Not Existe !!! ");
            }  
            return Ok(_book);
        }


        [HttpPut("Updateook/{IdBooktoUpdate}")]
        public IActionResult Updateook([FromRoute]int IdBooktoUpdate, [FromBody] BookVM book)
        {
            var _book = _bookService.UpdateBook(IdBooktoUpdate, book);
            if(_book == null)
            {
               NotFound("Book Not Found");
            }
            return Ok("Book Updated With Success ! ");
        }
    
        
        [HttpDelete("DeleteBook/{idBookToDelete}")]
        public IActionResult DeleteBook([FromRoute] int idBookToDelete)
        {
            int result = _bookService.DeleteBook(idBookToDelete);
            
            if (result == 0) return NotFound("Book Not Found");

            return Ok("Book Deleted");
        }

    
    }
}
