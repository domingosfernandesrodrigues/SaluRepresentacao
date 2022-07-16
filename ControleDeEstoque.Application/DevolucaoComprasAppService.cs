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
    public class DevolucaoComprasAppService : AppServiceBase<DevolucaoCompras>, IDevolucaoComprasAppService
    {
        private readonly IDevolucaoComprasService _devolucaoComprasService;

        public DevolucaoComprasAppService(IDevolucaoComprasService devolucaoComprasService)
            : base(devolucaoComprasService)
        {
            _devolucaoComprasService = devolucaoComprasService;
        }
        public IEnumerable<DevolucaoCompras> BuscarPorNotaFiscal(int notaFiscal)
        {
            return _devolucaoComprasService.BuscarPorNotaFiscal(notaFiscal);
        }
    }
}
