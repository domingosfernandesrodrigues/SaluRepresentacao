using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorVenda { get; set; }
        public int UnidadeMedidaId { get; set; }
        public int CategoriaId { get; set; }
        public int SubCategoriaId { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual Categoria Categoria{ get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
    }
}
