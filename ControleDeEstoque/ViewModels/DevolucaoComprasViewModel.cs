using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class DevolucaoComprasViewModel
    {
        [Key]
        public int DevolucaoCompraId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateOn { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DisplayName("Total Compra")]
        public string TotalCompra { get; set; }


        #region Relacionamento

        [DisplayName("Compra")]
        public int CompraId { get; set; }
        public virtual CompraViewModel Compra { get; set; }
        #endregion
    }
}