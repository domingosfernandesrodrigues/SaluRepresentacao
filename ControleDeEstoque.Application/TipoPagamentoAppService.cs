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
    public class TipoPagamentoAppService : AppServiceBase<TipoPagamento>, ITipoPagamentoAppService
    {
        private readonly ITipoPagamentoService _tipoPagamentoService;

        public TipoPagamentoAppService(ITipoPagamentoService tipoPagamentoService)
            : base(tipoPagamentoService)
        {
            _tipoPagamentoService = tipoPagamentoService;
        }
    }
}
