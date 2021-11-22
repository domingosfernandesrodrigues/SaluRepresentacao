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
    public class ParcelasCompraAppService : AppServiceBase<ParcelasCompra>, IParcelasCompraAppService
    {
        private readonly IParcelasCompraService _parcelasCompraService;

        public ParcelasCompraAppService(IParcelasCompraService parcelasCompraService)
            : base(parcelasCompraService)
        {
            _parcelasCompraService = parcelasCompraService;
        }
    }
}
