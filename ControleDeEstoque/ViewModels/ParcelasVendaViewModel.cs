using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class ParcelasVendaViewModel
    {
        [Key]
        public int ParcelasVendaId { get; set; }
        public int VendaId { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor!")]
        public decimal ValorVenda { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data Pagamento!")]
        [DisplayName("Data Pagamento")]
        public DateTime DataPagamento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data Vencimento!")]
        [DisplayName("Data Vencimento")]
        public DateTime DataVencimento { get; set; }

        public virtual VendaViewModel Venda { get; set; }
    }
}