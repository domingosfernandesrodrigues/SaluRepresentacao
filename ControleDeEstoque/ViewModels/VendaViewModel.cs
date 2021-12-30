using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class VendaViewModel
    {
        [Key]
        public int VendaId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateOn { get; set; }

        [DisplayName("Nota Fiscal")]
        public int NotaFiscal { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DisplayName("Total Venda")]
        public decimal TotalVenda { get; set; }

        [Required(ErrorMessage = "Preencha o campo Números de Parcelas!")]
        [DisplayName("Número Parcelas")]
        public int NumeroParcelas { get; set; }
        public string Status { get; set; }

        [DisplayName("À vista")]
        public int AVista { get; set; }

        [DisplayName("Cliente")]
        public int ClienteId { get; set; }

        [DisplayName("Formas Pagamento")]
        public int TipoPagamentoId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        public virtual TipoPagamentoViewModel TipoPagamento { get; set; }
    }
}