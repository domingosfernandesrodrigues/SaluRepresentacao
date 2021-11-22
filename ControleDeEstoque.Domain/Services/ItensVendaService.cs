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
    public class ItensVendaService : ServiceBase<ItensVenda>, IItensVendaService
    {
        private readonly IItensVendaRepository _itensVendaRepository;

        public ItensVendaService(IItensVendaRepository itensVendaRepository)
            : base(itensVendaRepository)
        {
            _itensVendaRepository = itensVendaRepository;
        }
    }
}
