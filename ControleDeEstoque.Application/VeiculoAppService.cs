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
    public class VeiculoAppService : AppServiceBase<Veiculo>, IVeiculoAppService
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculoAppService(IVeiculoService veiculoService)
            :base(veiculoService)
        {
            _veiculoService = veiculoService;
        }

        public IEnumerable<Veiculo> BuscarPorPlaca(string placa)
        {
            return _veiculoService.BuscarPorPlaca(placa);
        }
                
    }
}
