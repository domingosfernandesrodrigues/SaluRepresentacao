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
    public class CargoService : ServiceBase<Cargo>, ICargoService
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoService(ICargoRepository cargoRepository)
            : base(cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public IEnumerable<Cargo> BuscarPorNome(string nome)            
        {
            return _cargoRepository.BuscarPorNome(nome);
        }
    }
}
