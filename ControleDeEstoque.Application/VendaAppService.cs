using ControleDeEstoque.Application.Interface;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces.Services;
using ControleDeEstoque.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application
{
    public class VendaAppService : AppServiceBase<Venda>, IVendaAppService
    {
        private readonly IVendaService _vendaService;

        public VendaAppService(IVendaService vendaService)
            : base(vendaService)
        {
            _vendaService = vendaService;
        }
    }
}
