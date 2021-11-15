using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class ParcelasVenda
    {
        public int ParcelasVendaId { get; set; }
        public int VendaId { get; set; }
        public decimal ValorVenda { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }

        public virtual Venda Venda { get; set; }
    }
}
