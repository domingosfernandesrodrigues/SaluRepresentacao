using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string cpfcnpj { get; set; }
        public string rgie { get; set; }
        public string razaoSocial { get; set; }
        public string Tipo { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Fone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string EndNumero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
