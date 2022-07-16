using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }          
        public DateTime DtNascimento { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string PIS_PASEP { get; set; }
        public string CarteiraTrabalhoNumero { get; set; }
        public string CarteiraTrabalhoSerie { get; set; }
        public string CarteiraTrabalhoUF { get; set; }
        public decimal Remuneracao { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Fone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string EndNumero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime DtAdmissao { get; set; }

        #region Relacionamento

        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }

        #endregion



    }
}
