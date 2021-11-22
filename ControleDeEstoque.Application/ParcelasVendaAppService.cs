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
    public class ParcelasVendaAppService : AppServiceBase<ParcelasVenda>, IParcelasVendaAppService
    {
        private readonly IParcelasVendaService _parcelasVendaService;

        public ParcelasVendaAppService(IParcelasVendaService parcelasVendaService)
            : base(parcelasVendaService)
        {
            _parcelasVendaService = parcelasVendaService;
        }
    }
}
