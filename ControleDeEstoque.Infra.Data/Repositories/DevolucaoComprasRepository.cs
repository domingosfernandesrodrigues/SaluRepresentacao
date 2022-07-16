using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Repositories
{
    public class DevolucaoComprasRepository : RepositoryBase<DevolucaoCompras>, IDevolucaoComprasRepository
    {
        public IEnumerable<DevolucaoCompras> BuscarPorNotaFiscal(int notaFiscal)
        {
            return Db.DevolucaoCompras.Where(p => p.Compra.NotaFiscal == notaFiscal);
        }
    }
}
