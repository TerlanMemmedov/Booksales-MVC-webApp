using System.ComponentModel.DataAnnotations;

namespace BookSales.Models
{
    public class Translator //will be added IEntityBase for id
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name of the translator is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Picture of the translator is required")]
        [Display(Name = "Picture")]
        public string PictureUrl { get; set; }

        [Required(ErrorMessage = "The Biography of the translator is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relations
        public List<Book>? Books { get; set; }

    }
}
