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
    public class UnidadeMedidaService : ServiceBase<UnidadeMedida>, IUnidadeMedidaService
    {
        private readonly IUnidadeMedidaRepository _unidadeMedidaRepository;

        public UnidadeMedidaService(IUnidadeMedidaRepository unidadeMedidaRepository)
            : base(unidadeMedidaRepository)
        {
            _unidadeMedidaRepository = unidadeMedidaRepository;
        }
    }
}
