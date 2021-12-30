using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição!")]
        [MaxLength(300, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public string Foto { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DisplayName("Valor Pago")]
        public decimal ValorPago { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]

        [DisplayName("Valor Venda")]
        public decimal ValorVenda { get; set; }

        [DisplayName("Quantidade")]
        public double Qtde { get; set; }

        [DisplayName("Unidade de Medida")]
        public int UnidadeMedidaId { get; set; }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }

        [DisplayName("Subcategoria")]
        public int SubCategoriaId { get; set; }

        public virtual UnidadeMedidaViewModel UnidadeMedida { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
        public virtual SubCategoriaViewModel SubCategoria { get; set; }
    }
}