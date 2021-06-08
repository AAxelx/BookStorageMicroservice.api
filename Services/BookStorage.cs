using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStorageMicroservice_Module_6_Task_1_.Models;
using BookStorageMicroservice_Module_6_Task_1_.Services.Abstractions;
using BookStorageMicroservice_Module_6_Task_1_.Models.Enums;

namespace BookStorageMicroservice_Module_6_Task_1_.Services
{
    public class BookStorage : IBookStorage
    {
        private List<Book> _listOfBooks;

        public BookStorage()
        {
            _listOfBooks = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Name = "ClR via of C#", 
                    Pages = 325,
                    Lenguage = Lenguages.Russian
                },
                new Book
                {
                    Id = 2,
                    Name = "How to make friends and influence people",
                    Pages = 135,
                    Lenguage = Lenguages.English
                }
            };
        }

        public void Add(Book book)
        {
            _listOfBooks.Add(book);
        }

        public Book GetById(int? id)
        {
            return _listOfBooks.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Book book)
        {
            var id = _listOfBooks.FindIndex(f => f.Id == book.Id);
            _listOfBooks.RemoveAt(id);
            _listOfBooks.Insert(id, book);
        }

        public void Delete(Book book)
        {
            _listOfBooks.Remove(book);
        }
    }
}
