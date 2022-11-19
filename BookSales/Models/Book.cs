using BookSales.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSales.Models
{
    public class Book //will add :IEntityBase class for interface and inheritance
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name of the book is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Description for the book is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The price of the book is required")]
        [Display(Name = "Price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "The Picture for the book is required")]
        [Display(Name = "Picture")]
        public string PictureUrl { get; set; }

        [Required(ErrorMessage = "The Page numbers of the book is required")]
        [Display(Name = "Page number")]
        public int PageNumber { get; set; }

        [Required(ErrorMessage = "Book category for the book is required")]
        [Display(Name = "Book category")]
        public BookCategory BookCategory { get; set; }



        ////Relations
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        public int TranslatorId { get; set; }
        [ForeignKey("TranslatorId")]
        public Translator Translator { get; set; }

        public int PrintHouseId { get; set; }
        [ForeignKey("PrintHouseId")]
        public PrintHouse PrintHouse { get; set; }
        
    }
}
