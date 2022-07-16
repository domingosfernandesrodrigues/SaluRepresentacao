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
    public class CargoAppService : AppServiceBase<Cargo>, ICargoAppService
    {
        private readonly ICargoService _cargoService;

        public CargoAppService(ICargoService cargoService)
            :base(cargoService)
        {
            _cargoService = cargoService;
        }

        public IEnumerable<Cargo> BuscarPorNome(string nome)
        {
            return _cargoService.BuscarPorNome(nome);
        }
    }
}
