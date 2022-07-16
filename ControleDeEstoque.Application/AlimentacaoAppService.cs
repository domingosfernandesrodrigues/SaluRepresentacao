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
    public class AlimentacaoAppService : AppServiceBase<Alimentacao>, IAlimentacaoAppService
    {
        private readonly IAlimentacaoService _alimentacaoService;

        public AlimentacaoAppService(IAlimentacaoService alimentacaoService)
            : base(alimentacaoService)
        {
            _alimentacaoService = alimentacaoService;
        }
        public IEnumerable<Alimentacao> BuscarPorNome(string nome)
        {
            return _alimentacaoService.BuscarPorNome(nome);
        }
    }
}
