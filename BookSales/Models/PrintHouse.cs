using BookSales.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace BookSales.Models 
{
    public class PrintHouse : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name of the publishing house is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Picture of the publishing house is required")]
        [Display(Name = "Picture")]
        public string PictureUrl { get; set; }

        [Required(ErrorMessage = "The About section of the publishing house is required")]
        [Display(Name = "About")]
        public string About { get; set; }

        //Relations
        public List<Book>? Books { get; set; }
    }
}
