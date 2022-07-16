using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string NaturezaJuridica { get; set; }
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
