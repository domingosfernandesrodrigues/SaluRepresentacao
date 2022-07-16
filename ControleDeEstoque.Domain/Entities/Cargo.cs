using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nome { get; set; }
        public DateTime CreateOn { get; set; }
        public bool Ativo { get; set; }

        

    }
}
