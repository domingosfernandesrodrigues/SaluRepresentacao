using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class DevolucaoCompras
    {
        public int DevolucaoCompraId { get; set; }
        public DateTime CreateOn { get; set; }        
        public string TotalCompra { get; set; }           
        

        #region Relacionamento
        public int CompraId { get; set; }
        public virtual Compra Compra { get; set; }
        #endregion



    }
}
