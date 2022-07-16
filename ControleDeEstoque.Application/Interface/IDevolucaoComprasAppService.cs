using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.Interface
{
    public interface IDevolucaoComprasAppService : IAppServiceBase<DevolucaoCompras>
    {
        IEnumerable<DevolucaoCompras> BuscarPorNotaFiscal(int notaFiscal);
    }
}
