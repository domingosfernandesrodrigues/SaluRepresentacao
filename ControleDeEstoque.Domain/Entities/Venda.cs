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
        public string Status { get; set; }
        public int ClienteId { get; set; }
        public int TipoPagamentoId { get; set; }
        public int FuncionarioId { get; set; }
        public int EmpresaId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Empresa Empresa { get; set; }





    }
}
