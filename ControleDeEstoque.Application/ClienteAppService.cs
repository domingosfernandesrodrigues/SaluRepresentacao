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
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            :base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return _clienteService.BuscarPorNome(nome);
        }
    }
}
