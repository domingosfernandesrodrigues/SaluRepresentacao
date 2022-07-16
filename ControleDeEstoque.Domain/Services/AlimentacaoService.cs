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
    public class AlimentacaoService : ServiceBase<Alimentacao>, IAlimentacaoService
    {
        private readonly IAlimentacaoRepository _alimentacaoRepository;

        public AlimentacaoService(IAlimentacaoRepository alimentacaoRepository)
            : base(alimentacaoRepository)
        {
            _alimentacaoRepository = alimentacaoRepository;
        }

        public IEnumerable<Alimentacao> BuscarPorNome(string nome)
        {
            return _alimentacaoRepository.BuscarPorNome(nome);
        }
    }
}
