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
    public class ParcelasCompraService : ServiceBase<ParcelasCompra>, IParcelasCompraService
    {
        private readonly IParcelasCompraRepository _parcelasCompraRepository;

        public ParcelasCompraService(IParcelasCompraRepository parcelasCompraRepository)
            : base(parcelasCompraRepository)
        {
            _parcelasCompraRepository = parcelasCompraRepository;
        }
    }
}
