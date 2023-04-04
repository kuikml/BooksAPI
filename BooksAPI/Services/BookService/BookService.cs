namespace BooksAPI.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly BookContext _context;

        public BookService(BookContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var books = await _context.Book.Take(200).ToListAsync();
            return books;
        }

        public async Task<Book?> GetBook(int id)
        {
            
            var book = await _context.Book.FindAsync(id);
            if (book is null)
                return null;
            return book;
        }

        public async Task<List<Book>> AddBook(Book book)
        {
            _context.Add(book);
            await _context.SaveChangesAsync();
            return await _context.Book.ToListAsync();
        }

        public async Task<List<Book>?> UpdateBook(int id, Book request)
        {
            var book = await _context.Book.FindAsync(id);
            if (book is null)
                return null;

            book.Title = request.Title;
            book.Author = request.Author;
            book.Note = request.Note;
            book.Language = request.Language;
            book.Sites = request.Sites;
            book.ReviewsCount= request.ReviewsCount;
            book.NumberOpinions = request.NumberOpinions;
            book.Publication = request.Publication;
            book.Publisher= request.Publisher;

            await _context.SaveChangesAsync();
            return await _context.Book.ToListAsync();
        }

        public async Task<List<Book>?> DeleteBook(int id)
        {
            var book = await _context.Book.FindAsync(id);
            if (book is null)
                return null;

            _context.Remove(book);
            await _context.SaveChangesAsync();
            return await _context.Book.ToListAsync();
        }
    }
}

