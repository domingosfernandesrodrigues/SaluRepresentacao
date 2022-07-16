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
    public class DevolucaoComprasService : ServiceBase<DevolucaoCompras>, IDevolucaoComprasService
    {
        private readonly IDevolucaoComprasRepository _devolucaoComprasRepository;

        public DevolucaoComprasService(IDevolucaoComprasRepository devolucaoComprasRepository)
            : base(devolucaoComprasRepository)
        {
            _devolucaoComprasRepository = devolucaoComprasRepository;
        }

        public IEnumerable<DevolucaoCompras> BuscarPorNotaFiscal(int notaFiscal)
        {
            return _devolucaoComprasRepository.BuscarPorNotaFiscal(notaFiscal);
        }
    }
}
