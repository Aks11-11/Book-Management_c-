using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models
{
    public class Book
    {
        
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
