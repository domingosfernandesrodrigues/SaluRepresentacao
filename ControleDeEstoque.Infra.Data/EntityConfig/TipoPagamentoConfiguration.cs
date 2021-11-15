using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class TipoPagamentoConfiguration : EntityTypeConfiguration<TipoPagamento>
    {
        public TipoPagamentoConfiguration()
        {
            HasKey(tp => tp.TipoPagamentoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
