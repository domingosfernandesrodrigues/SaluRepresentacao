using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Repositories
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
    {
        public IEnumerable<Veiculo> BuscarPorPlaca(string placa)
        {
            return Db.Veiculo.Where(p => p.Placa == placa);
        }        
    }
}
