using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class BookSell
    {
        [Key]
        public int SellId { get; set; }
        public int CustomerId { get; set; }
        public DateTime  dtSell { get; set; }
        public int  BookId { get; set; }
        public int Qty { get; set; }
        public float Discount { get; set; }
        public float Total { get; set; }
        public float Paid { get; set; }
        public float Due { get; set; }
        public string Remarks { get; set; }

    }
}
