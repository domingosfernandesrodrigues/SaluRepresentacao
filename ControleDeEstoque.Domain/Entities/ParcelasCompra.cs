using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class ParcelasCompra
    {
        
        public int ParcelasCompraId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public int CompraId { get; set; }
        public virtual Compra Compra { get; set; }

    }
}
