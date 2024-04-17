using System.ComponentModel.DataAnnotations;

namespace LTW_Buoi1.Models.Domain
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public int Genre { get; set; }
        public string? CoverUrl { get; set; }
        public DateTime? DateAdded { get; set; }
        // One-to-many relation with author
        public int PublishersID { get; set; }
        public Publishers? publishers { get; set; }
        public List<Book_Author> book_Author { get; set; }
    }
}
