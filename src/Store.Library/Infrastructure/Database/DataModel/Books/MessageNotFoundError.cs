using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Store.Library.Infrastructure.Database.DataModel.Books
{
    public class BookNotFoundError : IActionResult
    {
        public BookNotFoundError() { }

        public BookNotFoundError(string bookId)
        {
            BookId = bookId;
        }

        /// <summary>
        /// Book ID not found.
        /// </summary>
        /// <value></value>
        public string BookId { get; set; }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var jsonResult = new JsonResult(this);
            jsonResult.StatusCode = StatusCodes.Status404NotFound;

            await jsonResult.ExecuteResultAsync(context);
        }
    }
}
