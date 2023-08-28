using System.ComponentModel.DataAnnotations;

namespace CoreMVC.Models
{
    public class Books
    {
        [Key]
        public int  BookID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
