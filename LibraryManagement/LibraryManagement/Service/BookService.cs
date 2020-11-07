using LibraryManagement.Data;
using LibraryManagement.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Service
{
    public class BookService
    {
        private BookContext _context;
        public BookService(BookContext context)
        {
            _context = context;
        }
        public List<Book> GetBookList()
        {
            try
            {
                var list = _context.tblBook.ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string BookSave(Book model)
        {
            try
            {
                _context.tblBook.Add(model);
                _context.SaveChanges();
                var result = "Save Successfully";
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string UpdateBook(int Id,Book model)
        {
            try
            {
                var OldBookData = _context.tblBook.Find(Id);
                OldBookData.BookName = model.BookName;
                OldBookData.AuthorName = model.AuthorName;
                OldBookData.Price = model.Price;
                _context.SaveChanges();
                return "Update Succesfully!!";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Book GetBookInfo(int Id)
        {
            try
            {
                var BookInfo = _context.tblBook.Where(x => x.BookId == Id).SingleOrDefault();
                return BookInfo;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string DaleteBook(int Id)
        {
            try
            {
                var isExistBook = _context.tblBook.Find(Id);
                if (isExistBook == null)
                    throw new SystemException("This book not found!! Please Check Book list");
                _context.tblBook.Remove(isExistBook);
                _context.SaveChanges();
                return "Delete Successfully";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
