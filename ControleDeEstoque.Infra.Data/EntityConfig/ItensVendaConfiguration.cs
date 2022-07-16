using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class ItensVendaConfiguration : EntityTypeConfiguration<ItensVenda>
    {
        public ItensVendaConfiguration()
        {
            HasKey(iv => iv.ItensVendaId);

            HasRequired(iv => iv.Venda)
                .WithMany()
                .HasForeignKey(iv => iv.VendaId);

            HasRequired(iv => iv.Produto)
                .WithMany()
                .HasForeignKey(iv => iv.ProdutoId);
                        
        }
    }
}
