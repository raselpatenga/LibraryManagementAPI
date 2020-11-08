using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data;
using LibraryManagement.Models;
using LibraryManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookSellController : Controller
    {
        private BookSellService bookSellService;
        public BookSellController(BookContext context)
        {
            bookSellService = new BookSellService(context);
        }

        ////Get api/Book
        [HttpGet]
        public ActionResult<BookSell> Get()
        {
            var list = bookSellService.GetBookSellList();
            return Ok(list);
        }

        //Post api/Book
        [HttpPost]
        public ActionResult Post([FromBody] BookSellReceive model)
        {
            try
            {
                var message = bookSellService.BookSave(model);
                return Ok(message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Book Save Unsuccess!! Errore this warning {ex.Message}");
            }
        }
    }
}