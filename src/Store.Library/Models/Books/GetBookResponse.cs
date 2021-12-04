using System.Collections.Generic;

namespace Store.Library.Models.Books
{
    public class GetBookReponse
    {
        IEnumerable<BookResponse> books { get; set; }

    }
}
