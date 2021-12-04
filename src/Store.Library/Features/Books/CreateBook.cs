using System.Threading.Tasks;
using Store.Library.Infrastructure.Database;
using Store.Library.Infrastructure.Database.DataModel.Books;

namespace Store.Library.Features.Books
{
    public class CreateBook
    {
        public readonly StoreContext _context;

        public CreateBook(StoreContext context)
        {
            _context = context;
        }

        public async Task Save(Book book)
        {
            _context.Add(book);
            await _context.SaveChangesAsync();
        }
    }
}
