using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Remuneracao
    {
        public int RemuneracaoId { get; set; }
        public decimal Valor { get; set; }
        public string TipoPagamento { get; set; }
        public DateTime CreateOn { get; set; }

        #region Relacionamento
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        #endregion



    }
}
