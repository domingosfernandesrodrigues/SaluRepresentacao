using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class ItensVenda
    {
        public int ItensVendaId { get; set; }
        public double Qtde { get; set; }
        public decimal Valor { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }

        public virtual Venda Venda { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
