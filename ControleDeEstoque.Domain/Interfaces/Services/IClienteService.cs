using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> BuscarPorNome(string nome);
    }
}
