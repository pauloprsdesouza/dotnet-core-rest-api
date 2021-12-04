using Store.Library.Infrastructure.Database.DataModel.Books;

namespace Store.Library.Models.Books
{
    public class PostBookRequest
    {
        public string Title { get; set; }

        public Book ToBook()
        {
            return new Book
            {
                Title = this.Title
            };
        }
    }
}
