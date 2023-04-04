global using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base .OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-S90QCIBO\\SQLEXPRESS;Database=KsiazkaDB2;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Book> Book { get; set; }
    }
}
