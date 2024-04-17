using System.ComponentModel.DataAnnotations;

namespace LTW_Buoi1.Models.Domain
{
    public class Publishers
    {
        [Key]
        public int Id { get; set; }
        public string? name { get; set; }
        public List<Books> books { get; set; }

    }
}
