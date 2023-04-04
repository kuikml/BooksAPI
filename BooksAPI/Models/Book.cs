namespace BooksAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public float Note { get; set; }
        public string Language { get; set; }
        public int Sites { get; set; }
        public int ReviewsCount { get; set; }
        public int NumberOpinions { get; set; }
        public DateTime Publication { get; set; }
        public string Publisher { get; set; }

    }
}
