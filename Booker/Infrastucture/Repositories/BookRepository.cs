using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Repositories
{
    public class BookRepository : IBookRepository
 
    {
        private static readonly ISet<Book> _books = new HashSet<Book>() { 
            new Book(1, "Tytul", "Tresc 1"),
            new Book(2, "Tytul2", "Tresc 2"),
            new Book(3, "Tytul3", "Tresc 3")
        };



        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book GetById(int id)
        {
            return _books.SingleOrDefault(x => x.Id == id);
        }

        public Book Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
