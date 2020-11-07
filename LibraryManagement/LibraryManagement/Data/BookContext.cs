using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    public class BookContext:DbContext
    {
        public DbSet<Book> tblBook { get; set; }

        public BookContext(DbContextOptions options) : base(options)
        {

        }
    }
}
