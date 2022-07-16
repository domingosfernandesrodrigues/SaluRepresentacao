using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class ItensCompraViewModel
    {
        [Key]
        public int ItensCompraId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Quantidade!")]
        [DisplayName("Quantidade")]
        public double Qtde { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Compra")]
        public int CompraId { get; set; }

        [DisplayName("Produto")]
        public int ProdutoId { get; set; }

        public virtual CompraViewModel Compra { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }
    }
}