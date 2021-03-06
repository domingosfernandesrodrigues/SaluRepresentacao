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
    public class ItensVendaAppService : AppServiceBase<ItensVenda>, IItensVendaAppService
    {
        private readonly IItensVendaService _itensVendaService;

        public ItensVendaAppService(IItensVendaService itensVendaService)
            : base(itensVendaService)
        {
            _itensVendaService = itensVendaService;
        }
    }
}
