using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Repositories
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        public IEnumerable<Funcionario> BuscarPorNome(string nome)
        {
            return Db.Funcionario.Where(p => p.Nome == nome);
        }
    }
}
