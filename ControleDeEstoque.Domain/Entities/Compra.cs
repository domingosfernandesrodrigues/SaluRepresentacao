using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime CreateOn { get; set; }
        public int NotaFiscal { get; set; }
        public decimal TotalCompra { get; set; }
        public string Status { get; set; }
        public int FornecedorId { get; set; }
        public int TipoPagamentoId { get; set; }
        public int EmpresaId { get; set; }
        
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }
        public virtual Empresa Empresa { get; set; }


    }
}
