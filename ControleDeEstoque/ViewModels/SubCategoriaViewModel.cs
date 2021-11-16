using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class SubCategoriaViewModel
    {
        [Key]
        public int SubCategoriaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        public string Nome { get; set; }
        public int CategoriaId { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }
    }
}