using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Venda
    {
        public int VendaId { get; set; }
        public DateTime CreateOn { get; set; }
        public int NotaFiscal { get; set; }
        public decimal TotalVenda { get; set; }
        public int NumeroParcelas { get; set; }
        public string Status { get; set; }
        public int AVista { get; set; }
        public int ClienteId { get; set; }
        public int TipoPagamentoId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual TipoPagamento TipoPagamento { get; set; }




    }
}
