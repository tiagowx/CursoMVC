using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CursoMVC.Models;

namespace CursoMVC.Models
{
    [Display(Name = "Produto")]
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Quantidade")]
        [Range(1,10, ErrorMessage = "Quantidade inválida")]
        public int Quantity { get; set; }

        [Display(Name = "Categoria")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
