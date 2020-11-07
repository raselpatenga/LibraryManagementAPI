using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data;
using LibraryManagement.Models;
using LibraryManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private BookService bookService;

        public BookController(BookContext context)
        {
            bookService = new BookService(context);
        }

        //Get api/Book
        [HttpGet]
        public ActionResult<Book> Get()
        {
            var list = bookService.GetBookList();
            return Ok(list);
        }

        //Post api/Book
        [HttpPost]
        public ActionResult Post([FromBody] Book model)
        {
            try
            {
                var message = bookService.BookSave(model);
                return Ok(message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Book Save Unsuccess!! Errore this warning {ex.Message}");
            }
        }

        //Put api/Book/id
        [HttpPut("{id}")]
        public ActionResult Put(int Id, [FromBody] Book model)
        {
            try
            {
                var message = bookService.UpdateBook(Id, model);
                return Ok(message);
            }
            catch(Exception ex)
            {
                return BadRequest($"Book Update Unsuccess!! Errore this warning {ex.Message}");
            }
        }

        // Get api/Book/id
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int Id)
        {
            try
            {
                var data = bookService.GetBookInfo(Id);
                if (data == null)
                    return NotFound("Data not found !!");
                else
                    return Ok(data);
            }
            catch(Exception ex)
            {
                return BadRequest($"Book this errore!! With this warning {ex.Message}");
            }
        }

        //Delete api/Book/id
        [HttpDelete("{id}")]
        public ActionResult Delete(int Id)
        {
            try
            {
                var message = bookService.DaleteBook(Id);
                return Ok(message);
            }
            catch(Exception ex)
            {
                return BadRequest($"Unsuccessfully Dalete!! {ex.Message}");
            }
        }
    }
}