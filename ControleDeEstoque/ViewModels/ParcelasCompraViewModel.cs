using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class ParcelasCompraViewModel
    {
        [Key]
        public int ParcelasCompraId { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data Pagamento!")]
        [DisplayName("Data Pagamento")]
        public DateTime DataPagamento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data Vencimento!")]
        [DisplayName("Data Vencimento")]
        public DateTime DataVencimento { get; set; }
        public int CompraId { get; set; }
        public virtual CompraViewModel Compra { get; set; }
    }
}