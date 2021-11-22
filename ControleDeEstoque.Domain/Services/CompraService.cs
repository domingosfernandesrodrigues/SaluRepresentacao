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
    public class CompraService : ServiceBase<Compra>, ICompraService
    {
        private readonly ICompraRepository _compraRepository;

        public CompraService(ICompraRepository compraRepository)
            :base(compraRepository)
        {
            _compraRepository = compraRepository;
        }
    }
}
