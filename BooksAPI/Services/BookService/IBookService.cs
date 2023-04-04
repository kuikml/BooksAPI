using BooksAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Services.BookService
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooks();

        Task<Book?> GetBook(int id);

        Task<List<Book>> AddBook(Book book);

        Task<List<Book>?> UpdateBook(int id, Book book);

        Task<List<Book>?> DeleteBook(int id);
    }
}
