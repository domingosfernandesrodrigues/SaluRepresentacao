using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class ItensCompraConfiguration : EntityTypeConfiguration<ItensCompra>
    {
        public ItensCompraConfiguration()
        {
            HasKey(ic => ic.ItensCompraId);

            HasRequired(ic => ic.Compra)
                .WithMany()
                .HasForeignKey(ic => ic.CompraId);

            HasRequired(ic => ic.Produto)
               .WithMany()
               .HasForeignKey(ic => ic.ProdutoId);

        }

    }
}
