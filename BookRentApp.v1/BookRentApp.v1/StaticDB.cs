using BookRentApp.v1.Models.DomainModels;
using BookRentApp.v1.Models.Enums;
using Microsoft.IdentityModel.Tokens;
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
                    Genre = Genre.SciFi,
                    Price = 3.20
                    
                },
                new Book()
                {
                    Id = 2,
                    Title = "The Blazing World",
                    Author = "Margaret Cavendish",
                    Year = 1666,
                    Genre = Genre.SciFi,
                    Price = 5.50
                },
                new Book()
                {
                    Id = 3,
                    Title = "And Then There Were None",
                    Author = "Agatha Christie",
                    Year = 1940,
                    Genre = Genre.Mystery,
                    Price = 2.90
                },
                new Book()
                {
                    Id = 4,
                    Title = "House of Leaves",
                    Author = "Mark Z. Danielewski",
                    Year = 2000,
                    Genre = Genre.Horror,
                    Price = 3.50
                },
                new Book()
                {
                    Id = 5,
                    Title = "When Breath Becomes Air",
                    Author = "Paul Kalanithi",
                    Year = 2016,
                    Genre = Genre.NonFiction,
                    Price = 4.20
                },
                new Book()
                {
                    Id = 5,
                    Title = "When Breath Becomes Air",
                    Author = "Paul Kalanithi",
                    Year = 2016,
                    Genre = Genre.NonFiction,
                    Price = 6.30
                },
                new Book()
                {
                    Id = 6,
                    Title = "Sapiens A Brief History of Humankind",
                    Author = "Yuval Noah Harari",
                    Year = 2011,
                    Genre = Genre.NonFiction,
                    Price = 3.20
                },
                new Book()
                {
                    Id = 7,
                    Title = "Manual for Living",
                    Author = "Epictetus",
                    Year = 101,
                    Genre = Genre.NonFiction,
                    Price = 1.80
                },
                new Book()
                {
                    Id = 8,
                    Title = "Don Quixote",
                    Author = "Miguel de Cervantes",
                    Year = 1605,
                    Genre = Genre.Comedy,
                    Price = 3.20
                },
                new Book()
                {
                    Id = 9,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Year = 1937,
                    Genre = Genre.Fiction,
                    Price = 5.10
                },
                new Book()
                {
                    Id = 10,
                    Title = "Lolita",
                    Author = "Vladimir Nabokov",
                    Year = 1955,
                    Genre = Genre.Romance,
                    Price = 4.70
                },
                new Book()
                {
                    Id = 11,
                    Title = "A Game of Thrones",
                    Author = "George R.R. Martin",
                    Year = 1996,
                    Genre = Genre.Fiction,
                    Price = 3.20
                }

            };

            Rentals = new List<Rent>();

            var rent1 = new Rent()
            {
                Id = 1,
                User = Users[0],
                MyLibrary = new List<Book>()
                    {
                        Library[0],
                        Library[2]
                    },
                IsRented = true

            };
            var rent2 = new Rent()
            {
                Id = 2,
                User = Users[1],
                MyLibrary = new List<Book>()
                    {
                        Library[0],
                        Library[2],
                        Library[3],
                        Library[1]
                    },
                IsRented = true
            };
            var rent3 = new Rent()
            {
                Id = 3,
                User = Users[2],
                MyLibrary = new List<Book>()
                    {
                        Library[5],
                        Library[3],
                        Library[2],

                    },
                IsRented = false
            };
            var rent4 = new Rent()
            {
                Id = 4,
                User = Users[3],
                MyLibrary = new List<Book>()
                    {
                        Library[10],
                        Library[9],

                    },

                IsRented = true
            };
            rent1.TotalPrice = PriceCalucator(rent1.MyLibrary);
            rent2.TotalPrice = PriceCalucator(rent2.MyLibrary);
            rent3.TotalPrice = PriceCalucator(rent3.MyLibrary);
            rent4.TotalPrice = PriceCalucator(rent4.MyLibrary);

            Rentals.Add(rent1);
            Rentals.Add(rent2);
            Rentals.Add(rent3);
            Rentals.Add(rent4);
        }

        private static double PriceCalucator(List<Book> books)
        {
            var sum = 0.00;
            foreach (var book in books)
            {
                sum += book.Price;
            }
            return sum;
        }
    }
}
