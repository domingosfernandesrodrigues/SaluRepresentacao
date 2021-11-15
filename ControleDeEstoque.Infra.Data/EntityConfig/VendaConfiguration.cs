using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class VendaConfiguration : EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {
            HasKey(p => p.VendaId);

            HasRequired(p => p.TipoPagamento)
                .WithMany()
                .HasForeignKey(p => p.TipoPagamentoId);
            
            //HasRequired(p => p.Cliente)
            //    .WithMany()
            //    .HasForeignKey(p => p.ClienteId);
        }
    }
}
