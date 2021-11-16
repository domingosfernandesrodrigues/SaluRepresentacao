using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class CompraViewModel
    {
        [Key]
        public int CompraId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCompra { get; set; }

        [DisplayName("Nota Fiscal")]
        public int NotaFiscal { get; set; }

        [DisplayName("Total Compra")]
        public decimal TotalCompra { get; set; }

        [DisplayName("Número Parcela")]
        public int NumeroParcela { get; set; }
        public string Status { get; set; }
        public int FornecedorId { get; set; }
        public int TipoPagamentoId { get; set; }

        public virtual FornecedorViewModel Fornecedor { get; set; }
        public virtual TipoPagamentoViewModel TipoPagamento { get; set; }
    }
}