using LibraryManagement.Data;
using LibraryManagement.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Service
{
    public class BookSellService
    {
        private BookContext _context;
        public BookSellService(BookContext context)
        {
            _context = context;
        }
        public List<BookSell> GetBookSellList()
        {
            try
            {
                var list = _context.BookSell.ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string BookSave(BookSellReceive model)
        {
            try
            {
                var booksell = new BookSell();
                booksell.Id = model.SellId;
                booksell.CustomerId = model.CustomerId;
                booksell.dtSell = model.dtSell;
                _context.BookSell.Add(booksell);
                _context.SaveChanges();

                var bookSelldetails = new BookSellDetails();
                foreach (BookSellReceiveDetails item in model.BookSellRecvDetailsList)
                {
                    bookSelldetails = new BookSellDetails();
                    bookSelldetails.BookSellId = item.SellId;
                    bookSelldetails.BookId = item.BookId;
                    bookSelldetails.Qty = item.Qty;
                    bookSelldetails.Discount = item.Discount;
                    bookSelldetails.Total = item.Total;
                    bookSelldetails.Paid = item.Paid;
                    bookSelldetails.Due = item.Due;
                    bookSelldetails.Remarks = item.Remarks;
                    _context.BookSellDetails.Add(bookSelldetails);
                    _context.SaveChanges();
                }
                   
                var result = "Save Successfully";
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
