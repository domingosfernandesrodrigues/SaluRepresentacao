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
    public class RemuneracaoAppService : AppServiceBase<Remuneracao>, IRemuneracaoAppService
    {
        private readonly IRemuneracaoService _remuneracaoService;

        public RemuneracaoAppService(IRemuneracaoService remuneracaoService)
            : base(remuneracaoService)
        {
            _remuneracaoService = remuneracaoService;
        }
        public IEnumerable<Remuneracao> BuscarPorNome(string nome)
        {
            return _remuneracaoService.BuscarPorNome(nome);
        }
    }
}
