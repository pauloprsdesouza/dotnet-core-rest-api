using System.Threading.Tasks;
using Store.Library.Infrastructure.Database;
using Store.Library.Infrastructure.Database.DataModel.Books;

namespace Store.Library.Features.Books
{
    public class BookUpdate
    {
        public readonly StoreContext _context;

        public BookUpdate(StoreContext context)
        {
            _context = context;
        }

        public async Task Update(Book book)
        {
            _context.Update(book);
            await _context.SaveChangesAsync();
        }
    }
}
