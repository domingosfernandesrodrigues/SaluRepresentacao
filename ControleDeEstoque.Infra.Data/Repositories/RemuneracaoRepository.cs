using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Repositories
{
    public class RemuneracaoRepository : RepositoryBase<Remuneracao>, IRemuneracaoRepository
    {
        public IEnumerable<Remuneracao> BuscarPorNome(string nome)
        {
            return Db.Remuneracao.Where(p => p.Funcionario.Nome == nome);
        }
    }
}
