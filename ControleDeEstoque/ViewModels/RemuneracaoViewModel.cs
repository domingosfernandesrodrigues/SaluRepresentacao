using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class RemuneracaoViewModel
    {
        [Key]
        public int RemuneracaoId { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Tipo")]
        public string TipoPagamento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateOn { get; set; }

        #region Relacionamento

        [DisplayName("Funcionário")]
        public int FuncionarioId { get; set; }
        public virtual FuncionarioViewModel Funcionario { get; set; }
        #endregion
    }
}