using System.Linq;
using Store.Library.Infrastructure.Database.DataModel.Books;

namespace Store.Library.Infrastructure.Repositories.Books
{
    public static class BookQuery
    {
        public static IQueryable<Book> GetAll(this IQueryable<Book> books)
        {
            return books;
        }

        public static Book ById(this IQueryable<Book> books, int id){
            return books.Where(book => book.Id == id).FirstOrDefault();
        }
    }
}
