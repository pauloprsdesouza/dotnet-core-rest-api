using System.Collections.Generic;
using System.Linq;
using Store.Library.Infrastructure.Database;
using Store.Library.Infrastructure.Database.DataModel.Books;
using Store.Library.Infrastructure.Repositories.Books;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Store.Library.Models.Books;
using Store.Library.Features.Books;
using System.Threading.Tasks;
using Store.Library.Infrastructure.Serialization.Books;

namespace Store.Library.Controllers;

[Route("books")]
public class BooksController : Controller
{
    private StoreContext _context;

    public BooksController(StoreContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Get books
    /// </summary>
    /// <remarks>
    /// Registered books in a store.
    /// </remarks>
    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    public IActionResult List()
    {
        ICollection<Book> books = _context.Books.GetAll().ToList();
        return Json(books);
    }

    /// <summary>
    /// Create a book
    /// </summary>
    /// <remarks>
    /// Create a new book in a store.
    /// </remarks>
    [HttpPost]
    [Produces(MediaTypeNames.Application.Json)]
    public async Task<IActionResult> Create([FromBody] PostBookRequest request)
    {
        var createBook = new CreateBook(_context);
        var book = request.ToBook();

        await createBook.Save(book);

        return Ok(book.MapToResponse());
    }

    /// <summary>
    /// Delete a book
    /// </summary>
    /// <remarks>
    /// Delete an existing book.
    /// </remarks>
    /// <param name="bookId" example="1">Books's ID</param>
    [HttpDelete, Route("{bookId}")]
    [Produces(MediaTypeNames.Application.Json)]
    public async Task<IActionResult> Delete([FromRoute] int bookId)
    {
        var bookSearch = new BookSearch(_context);
        var book = bookSearch.Find(bookId);

        if (bookSearch.MessageNotFound)
        {
            return NotFound(new BookNotFoundError(bookId.ToString()));
        }

        var deleteBook = new DeleteBook(_context);
        await deleteBook.Delete(book);

        return Ok(book.MapToResponse());
    }

    /// <summary>
    /// Update a book
    /// </summary>
    /// <remarks>
    /// Update an existing book.
    /// </remarks>
    /// <param name="bookId" example="1">Books's ID</param>
    /// <param name="request" example="A Book for Developers">Books's Title</param>
    [HttpPut, Route("{bookId}")]
    [Produces(MediaTypeNames.Application.Json)]
    public async Task<IActionResult> Update([FromRoute] int bookId, [FromBody] PutBookRequest request)
    {
        var bookSearch = new BookSearch(_context);
        var book = bookSearch.Find(bookId);

        if (bookSearch.MessageNotFound)
        {
            return NotFound(new BookNotFoundError(bookId.ToString()));
        }

        var updateBook = new BookUpdate(_context);
        await updateBook.Update(book);

        return Ok(book.MapToResponse());
    }
}
