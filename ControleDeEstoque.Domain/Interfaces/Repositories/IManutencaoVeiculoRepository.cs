using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Interfaces
{
    public interface IManutencaoVeiculoRepository : IRepositoryBase<ManutencaoVeiculo>
    {
        IEnumerable<ManutencaoVeiculo> BuscarPorPlaca(string placa);
    }
}
