using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public int VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateOn { get; set; }
        public bool Ativo { get; set; }

        [DisplayName("Empresa")]
        public int EmpresaId { get; set; }
        public virtual EmpresaViewModel Empresa { get; set; }
    }
}