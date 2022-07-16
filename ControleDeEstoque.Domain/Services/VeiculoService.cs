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
    public class VeiculoService : ServiceBase<Veiculo>, IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)                                   
            : base(veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public IEnumerable<Veiculo> BuscarPorPlaca(string placa)            
        {
            return _veiculoRepository.BuscarPorPlaca(placa);
        }
    }
}
