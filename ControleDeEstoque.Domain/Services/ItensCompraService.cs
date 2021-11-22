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
    public class ItensCompraService : ServiceBase<ItensCompra>, IItensCompraService
    {
        private readonly IItensCompraRepository _itensCompraRepository;

        public ItensCompraService(IItensCompraRepository itensCompraRepository)
            : base(itensCompraRepository)
        {
            _itensCompraRepository = itensCompraRepository;
        }
    }
}
