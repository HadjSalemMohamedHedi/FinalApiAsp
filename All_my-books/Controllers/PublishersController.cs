using All_my_books.Data.Services;
using All_my_books.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace All_my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        public readonly PublishersService _publisherService;
        public PublishersController(PublishersService PublisherService)
        {
            _publisherService = PublisherService;
        }


        [HttpPost]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            _publisherService.AddPublisher(publisher);
            return Ok("Publisher Added with success !!! ");
        }

        [HttpGet("GetPublisherData/{PublisherId}")]
        public IActionResult GetPublisherData([FromRoute] int PublisherId)
        {
            var response = _publisherService.GetPublisherData(PublisherId);
            return Ok(response);
        }


        [HttpDelete("Delete-PubisherById/{PublisherId}")]
        public IActionResult DeletePublisherById([FromRoute]int PublisherId)
        {
             _publisherService.DeletePublisherById(PublisherId);
            return Ok();
        }

    }
}
