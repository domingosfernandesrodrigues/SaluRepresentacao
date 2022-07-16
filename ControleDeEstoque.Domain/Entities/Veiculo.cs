using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public DateTime CreateOn { get; set; }
        public bool Ativo { get; set; }

        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }



    }
}
