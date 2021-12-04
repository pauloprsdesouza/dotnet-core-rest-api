using Store.Library.Infrastructure.Database;
using Store.Library.Infrastructure.Repositories.Books;
using Store.Library.Infrastructure.Database.DataModel.Books;

namespace Store.Library.Features.Books
{
    public class BookSearch
    {
        public readonly StoreContext _context;

        public BookSearch(StoreContext context)
        {
            _context = context;
        }

        public bool MessageNotFound { get; private set; }

        public Book Find(int id)
        {
            Book book = _context.Books.ById(id);

            MessageNotFound = book == null;

            return book;
        }
    }
}
