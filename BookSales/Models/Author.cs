using BookSales.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace BookSales.Models
{
    public class Author : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name of the author is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Picture of the author is required")]
        [Display(Name = "Picture")]
        public string PictureUrl { get; set; }

        [Required(ErrorMessage = "The Biography of the author is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relations
        public List<Book>? Books { get; set; }
    }
}
