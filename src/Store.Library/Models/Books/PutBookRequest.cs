using Store.Library.Infrastructure.Database.DataModel.Books;

namespace Store.Library.Models.Books
{
    public class PutBookRequest
    {
        public string Title { get; set; }

        public void MapToBook(Book book)
        {
            book.Title = Title;
        }
    }
}
