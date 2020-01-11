using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstTry.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int ISBN { get; set; }
        [Required]
        [Display(Name = "Слика")]
        public string Img { get; set; }
        [Required]     
        [Display(Name = "Наслов")]
        public string Title { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Година")]
        [Range(1300, 2020)]
        public int Year { get; set; }
        [Required]
        [Display(Name = "Жанр")]
        public string Genre { get; set; }
    }

}