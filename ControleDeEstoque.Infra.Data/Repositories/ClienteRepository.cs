using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return Db.Cliente.Where(p => p.Nome == nome);
        }
    }
}
