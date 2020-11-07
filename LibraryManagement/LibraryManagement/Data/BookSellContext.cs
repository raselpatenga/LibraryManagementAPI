using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    public class BookSellContext:DbContext
    {
        public DbSet<BookSell> tblBoolSell { get; set; }

        public BookSellContext(DbContextOptions options) : base(options)
        {

        }
    }
}
