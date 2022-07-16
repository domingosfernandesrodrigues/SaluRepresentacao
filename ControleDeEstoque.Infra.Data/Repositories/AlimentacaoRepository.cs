using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Repositories
{
    public class AlimentacaoRepository : RepositoryBase<Alimentacao>, IAlimentacaoRepository
    {
        public IEnumerable<Alimentacao> BuscarPorNome(string nome)
        {
            return Db.Alimentacao.Where(p => p.Funcionario.Nome == nome);
        }
    }
}
