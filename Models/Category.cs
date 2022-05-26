using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    [Display(Name = "Categoria")]
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        public List<Product> Products { get; set; }
    }
}
