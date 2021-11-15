using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class ParcelasCompraConfiguration : EntityTypeConfiguration<ParcelasCompra>
    {
        public ParcelasCompraConfiguration()
        {
            HasKey(p => p.ParcleasCompraId);

            HasRequired(p => p.Compra)
                .WithMany()
                .HasForeignKey(p => p.CompraId);
        }
    }
}
