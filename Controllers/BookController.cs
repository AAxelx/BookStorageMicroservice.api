using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStorageMicroservice_Module_6_Task_1_.Models;
using BookStorageMicroservice_Module_6_Task_1_.Properties;
using BookStorageMicroservice_Module_6_Task_1_.Services;

namespace BookStorageMicroservice_Module_6_Task_1_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private BookStorage _bookStorage;
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/controller/action")]
        public IActionResult GetById([FromQuery] int id)
        {
            return Ok(new SomeResponse<Book> { Status = true, Message = "All is okey" });
        }

        [HttpGet]
        public IActionResult Post([FromBody] int? id, [FromBody] Book book)
        {
            if (id != null)
            {
                _bookStorage.Add(book);
                return Ok(new SomeResponse<Book> { Status = true, Message = "All is okey" });
            }
            else
                return NotFound(new SomeResponse<Book> { Status = false, Message = $"We can't create book with this id{id}" });
        }

        [HttpGet]
        public IActionResult Delete([FromBody] Book book)
        {
            if (book != null)
            {
                _bookStorage.Delete(book);
                return Ok(new SomeResponse<Book> { Status = true, Message = "All is okey" });
            }
            else
                return NotFound(new SomeResponse<Book> { Status = false, Message = $"We can't found this book" });
        }

        [HttpGet]
        public IActionResult Put([FromBody] Book book, [FromBody] int? id)
        {
            if(id != null)
            {
                _bookStorage.Update(book);
                return Ok(new SomeResponse<Book> { Status = true, Message = "All is okey" });
            }
            else
                return NotFound(new SomeResponse<Book> { Status = false, Message = $"We can't found book with this id{id}"});
        }
    }
}
