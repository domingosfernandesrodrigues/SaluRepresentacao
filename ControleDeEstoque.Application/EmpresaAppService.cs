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
    public class EmpresaAppService : AppServiceBase<Empresa>, IEmpresaAppService
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaAppService(IEmpresaService empresaService)
            :base(empresaService)
        {
            _empresaService = empresaService;
        }

        public IEnumerable<Empresa> BuscarPorNome(string nome)
        {
            return _empresaService.BuscarPorNome(nome);
        }
    }
}
