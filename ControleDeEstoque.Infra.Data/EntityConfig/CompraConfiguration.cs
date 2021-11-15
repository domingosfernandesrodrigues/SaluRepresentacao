using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class CompraConfiguration : EntityTypeConfiguration<Compra>
    {
        public CompraConfiguration()
        {
            HasKey(c => c.CompraId);

            HasRequired(c => c.Fornecedor)
                .WithMany()
                .HasForeignKey(c => c.FornecedorId);

            HasRequired(c => c.TipoPagamento)
                .WithMany()
                .HasForeignKey(c => c.TipoPagamentoId);

        }
    }
}
