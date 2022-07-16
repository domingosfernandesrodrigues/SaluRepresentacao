using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Alimentacao
    {
        public int AlimentacaoId { get; set; }
        public decimal Valor { get; set; }
        public string TipoAlimentacao { get; set; }
        public int Qtd { get; set; }
        public DateTime CreateOn { get; set; }

        #region Relacionamento
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        #endregion



    }
}
