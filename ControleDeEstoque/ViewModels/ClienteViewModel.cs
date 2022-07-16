using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class ClienteViewModel 
    {
        [Key]
        public int ClienteId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateOn { get; set; }
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ!")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]        
        [DisplayName("CNPJ")]
        public string cpfcnpj { get; set; }

        [Required(ErrorMessage = "Preencha o campo RG!")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("RG")]
        public string rgie { get; set; }

        [Required(ErrorMessage = "Preencha o campo Razão Social!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        [DisplayName("Razão Social")]
        public string razaoSocial { get; set; }
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]        
        public string CEP { get; set; }

        [Required(ErrorMessage = "Preencha o campo Endereço!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        public string Bairro { get; set; }
        public string Fone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Celular!")]
        [MaxLength(18, ErrorMessage = "Máximo {0} caracteres")]        
        public string Celular { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Número!")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres ")]
        [DisplayName("Número")]
        public string EndNumero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        
        
    }
}