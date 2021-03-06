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
    public class UnidadeMedidaAppService : AppServiceBase<UnidadeMedida>, IUnidadeMedidaAppService
    {
        private readonly IUnidadeMedidaService _unidadeMedidaService;

        public UnidadeMedidaAppService(IUnidadeMedidaService unidadeMedidaService)
            : base(unidadeMedidaService)
        {
            _unidadeMedidaService = unidadeMedidaService;
        }
    }
}
