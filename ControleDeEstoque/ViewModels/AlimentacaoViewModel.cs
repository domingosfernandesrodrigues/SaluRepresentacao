using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class AlimentacaoViewModel
    {
        [Key]
        public int AlimentacaoId { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }
        
        [DisplayName("Tipo")]
        public string TipoAlimentacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Quantidade!")]
        [DisplayName("Quantidade")]
        public int Qtd { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateOn { get; set; }

        #region Relacionamento

        [DisplayName("Funcionário")]
        public int FuncionarioId { get; set; }
        public virtual FuncionarioViewModel Funcionario { get; set; }
        #endregion
    }
}