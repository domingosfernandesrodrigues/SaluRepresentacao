using ControleDeEstoque.Application.Interface;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application
{
    public class ManutencaoVeiculoAppService : AppServiceBase<ManutencaoVeiculo>, IManutencaoVeiculoAppService
    {
        private readonly IManutencaoVeiculoService _ManutencaoVeiculoService;

        public ManutencaoVeiculoAppService(IManutencaoVeiculoService ManutencaoVeiculoService)
            :base(ManutencaoVeiculoService)
        {
            _ManutencaoVeiculoService = ManutencaoVeiculoService;
        }

        public IEnumerable<ManutencaoVeiculo> BuscarPorPlaca(string placa)
        {
            return _ManutencaoVeiculoService.BuscarPorPlaca(placa);
        }
                
    }
}
