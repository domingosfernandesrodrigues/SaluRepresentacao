using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using ControleDeEstoque.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Services
{
    public class ManutencaoVeiculoService : ServiceBase<ManutencaoVeiculo>, IManutencaoVeiculoService
    {
        private readonly IManutencaoVeiculoRepository _ManutencaoVeiculoRepository;

        public ManutencaoVeiculoService(IManutencaoVeiculoRepository manutencaoVeiculoRepository)
            : base(manutencaoVeiculoRepository)
        {
            _ManutencaoVeiculoRepository = manutencaoVeiculoRepository;
        }

        public IEnumerable<ManutencaoVeiculo> BuscarPorPlaca(string placa)            
        {
            return _ManutencaoVeiculoRepository.BuscarPorPlaca(placa);
        }
    }
}
