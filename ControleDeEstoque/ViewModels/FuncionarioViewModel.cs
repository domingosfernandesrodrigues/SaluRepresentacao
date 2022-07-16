using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class FuncionarioViewModel
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        public string Sobrenome { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Pai")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        [DisplayName("Nome do Pai")]
        public string NomePai { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome da Mãe")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        [DisplayName("Nome da Mãe")]
        public string NomeMae { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o campo RG")]
        [MaxLength(09, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("RG")]
        public string RG { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo PIS")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("PIS")]
        public string PIS_PASEP { get; set; }

        [Required(ErrorMessage = "Preencha o campo CTPS Número")]
        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CTPS Número")]
        public string CarteiraTrabalhoNumero { get; set; }

        [Required(ErrorMessage = "Preencha o campo CTPS Série")]
        [MaxLength(4, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CTPS Série")]
        public string CarteiraTrabalhoSerie { get; set; }

        [Required(ErrorMessage = "Preencha o campo CTPS UF")]
        [MaxLength(02, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CTPS UF")]
        public string CarteiraTrabalhoUF { get; set; }

        [DisplayName("Remuneraçao")]
        public decimal Remuneracao { get; set; }
        public string CEP { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Fone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Celular")]
        [MaxLength(18, ErrorMessage = "Máximo {0} caracteres")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Número")]
        public string EndNumero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        [DisplayName("Data de Admissão")]
        public DateTime DtAdmissao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateOn { get; set; }

        #region Relacionamento

        [DisplayName("Cargo")]
        public int CargoId { get; set; }
        public virtual CargoViewModel Cargo { get; set; }

        #endregion
    }
}