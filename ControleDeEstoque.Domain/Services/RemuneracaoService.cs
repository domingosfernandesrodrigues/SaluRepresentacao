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
    public class RemuneracaoService : ServiceBase<Remuneracao>, IRemuneracaoService
    {
        private readonly IRemuneracaoRepository _remuneracaoRepository;

        public RemuneracaoService(IRemuneracaoRepository remuneracaoRepository)
            : base(remuneracaoRepository)
        {
            _remuneracaoRepository = remuneracaoRepository;
        }

        public IEnumerable<Remuneracao> BuscarPorNome(string nome)
        {
            return _remuneracaoRepository.BuscarPorNome(nome);
        }
    }
}
