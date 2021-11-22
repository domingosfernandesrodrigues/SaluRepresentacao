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
    public class ItensCompraAppService : AppServiceBase<ItensCompra>, IItensCompraAppService
    {
        private readonly IItensCompraService _itensCompraService;

        public ItensCompraAppService(IItensCompraService itensCompraService) 
            : base(itensCompraService)
        {
            _itensCompraService = itensCompraService;
        }
    }
}
