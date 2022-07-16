using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class DevolucaoComprasConfiguration : EntityTypeConfiguration<DevolucaoCompras>
    {
        public DevolucaoComprasConfiguration()
        {
            HasKey(f => f.DevolucaoCompraId);

            HasRequired(p => p.Compra)
                .WithMany()
                .HasForeignKey(p => p.CompraId);
        }
    }
}
