using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class ManutencaoVeiculo
    {
        public int ManutencaoVeiculoId { get; set; }
        public string Servico { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime CreateOn { get; set; }

        public int VeiculoId { get; set; }
        public virtual Veiculo Veiculo { get; set; }



    }
}
