using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class ItensCompra 
    {
        public int ItensCompraId { get; set; }
        public double Qtde { get; set; }
        public decimal Valor { get; set; }
        public int CompraId { get; set; }
        public int ProdutoId { get; set; }

        public virtual Compra Compra { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
