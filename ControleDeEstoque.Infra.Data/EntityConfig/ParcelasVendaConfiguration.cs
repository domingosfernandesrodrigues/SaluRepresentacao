using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class ParcelasVendaConfiguration : EntityTypeConfiguration<ParcelasVenda>
    {
        public ParcelasVendaConfiguration()
        {
            HasKey(p => p.ParcelasVendaId);

            HasRequired(p => p.Venda)
                .WithMany()
                .HasForeignKey(p => p.VendaId);
        }
    }
}
