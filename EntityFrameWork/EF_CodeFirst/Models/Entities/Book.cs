using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookYeafOfPublication { get; set; }
        public int BookEditionNumber { get; set; }
        public int BookNumberOfPages { get; set; }
        public int BookQuantitiy { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthoerId { get; set; }
        public Author Author { get; set; }  
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}