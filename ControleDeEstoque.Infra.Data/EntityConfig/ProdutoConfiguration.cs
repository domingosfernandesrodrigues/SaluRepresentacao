using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(300);

            HasRequired(p => p.UnidadeMedida)
                .WithMany()
                .HasForeignKey(p => p.UnidadeMedidaId);

            HasRequired(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.CategoriaId);

            HasRequired(p => p.SubCategoria)
                .WithMany()
                .HasForeignKey(p => p.SubCategoriaId);



        }
    }
}
