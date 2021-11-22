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
    public class TipoPagamentoService : ServiceBase<TipoPagamento>, ITipoPagamentoService
    {
        private readonly ITipoPagamentoRepository _tipoPagamentoRepository;

        public TipoPagamentoService(ITipoPagamentoRepository tipoPagamentoRepository)
            : base(tipoPagamentoRepository)
        {
            _tipoPagamentoRepository = tipoPagamentoRepository;
        }
    }
}
