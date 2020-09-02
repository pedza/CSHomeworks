using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRentApp.v1.Models.DomainModels
{
    public class Rent
    {
        public int Id { get; set; }
        public List<Book> MyLibrary { get; set; }
        public User User { get; set; }
        public bool IsRented { get; set; }
        

    }
}
