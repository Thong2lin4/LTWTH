using System.ComponentModel.DataAnnotations;

namespace LTW_Buoi1.Models.Domain
{
    public class Book_Author
    {
        [Key]
        public int Id { get; set; }
        public int? BooksID { get; set; }
        public int? AuthorsID { get; set; }
        public Books? Books { get; set; }
        public Authors? Authors { get; set; }
    }
}
