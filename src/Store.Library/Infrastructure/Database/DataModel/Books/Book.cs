using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Library.Infrastructure.Database.DataModel.Books
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
