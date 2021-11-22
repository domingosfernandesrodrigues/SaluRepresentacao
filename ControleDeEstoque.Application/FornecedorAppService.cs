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
    public class FornecedorAppService : AppServiceBase<Fornecedor>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService fornecedorService)
            : base(fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }
        public IEnumerable<Fornecedor> BuscarPorNome(string nome)
        {
            return _fornecedorService.BuscarPorNome(nome);
        }
    }
}
