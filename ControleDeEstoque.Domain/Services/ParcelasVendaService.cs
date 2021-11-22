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
    public class ParcelasVendaService : ServiceBase<ParcelasVenda>, IParcelasVendaService
    {
        private readonly IParcelasVendaRepository _parcelasVendaRepository;

        public ParcelasVendaService(IParcelasVendaRepository parcelasVendaRepository)
            : base(parcelasVendaRepository)
        {
            _parcelasVendaRepository = parcelasVendaRepository;
        }
    }
}
