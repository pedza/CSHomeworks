using BookRentApp.v1.Models.DomainModels;
using BookRentApp.v1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRentApp.v1
{
    public static class StaticDB
    {
        public static List<User> Users { get; set; }
        public static List<Rent> Rentals { get; set; }
        public static List<Book> Library { get; set; }

        static StaticDB()
        {
            Users = new List<User>()
            {
                new User()
                { 
                    Id = 1,
                    FirstName = "Vesna",
                    LastName = "Janevska",
                    Age = 32,
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Predrag",
                    LastName = "Janevski",
                    Age = 33,
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Ivica",
                    LastName = "Janevski",
                    Age = 38,
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Petko",
                    LastName = "Petkovski",
                    Age = 38,
                }

            };

            Library = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "The Three-Body Problem",
                    Author = "Liu Cixin",
                    Year = 2008,
                    Genre = Genre.SciFi
                },
                new Book()
                {
                    Id = 2,
                    Title = "The Blazing World",
                    Author = "Margaret Cavendish",
                    Year = 1666,
                    Genre = Genre.SciFi
                },
                new Book()
                {
                    Id = 3,
                    Title = "And Then There Were None",
                    Author = "Agatha Christie",
                    Year = 1940,
                    Genre = Genre.Mystery
                },
                new Book()
                {
                    Id = 4,
                    Title = "House of Leaves",
                    Author = "Mark Z. Danielewski",
                    Year = 2000,
                    Genre = Genre.Horror
                }

            };

            Rentals = new List<Rent>()
            {
                new Rent()
                {
                    Id = 1,
                    User = Users[0],
                    MyLibrary = new List<Book>()
                    {
                        Library[0],
                        Library[2]
                    },
                    IsRented = true
                    
                }

            };
        }
    }
}
