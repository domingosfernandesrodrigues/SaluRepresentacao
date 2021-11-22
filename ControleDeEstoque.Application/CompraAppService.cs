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
    public class CompraAppService : AppServiceBase<Compra>, ICompraAppService
    {
        private readonly ICompraService _compraService;

        public CompraAppService(ICompraService compraService)
            : base(compraService)
        {
            _compraService = compraService;
        }
    }
}
