using Store.Library.Infrastructure.Database.DataModel.Books;
using Store.Library.Models.Books;

namespace Store.Library.Infrastructure.Serialization.Books
{
    public static class BookMap
    {
        public static BookResponse MapToResponse(this Book book)
        {
            return new BookResponse
            {
                Id = book.Id,
                Title = book.Title
            };
        }
    }
}
