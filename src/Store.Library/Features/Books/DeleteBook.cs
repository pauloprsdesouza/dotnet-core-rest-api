using System.Threading.Tasks;
using Store.Library.Infrastructure.Database;
using Store.Library.Infrastructure.Database.DataModel.Books;

namespace Store.Library.Features.Books
{
    public class DeleteBook
    {
        private readonly StoreContext _context;

        public DeleteBook(StoreContext context)
        {
            _context = context;
        }

        public async Task Delete(Book book)
        {
            _context.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
