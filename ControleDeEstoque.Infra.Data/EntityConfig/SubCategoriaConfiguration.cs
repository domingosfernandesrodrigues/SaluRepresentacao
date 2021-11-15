using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class SubCategoriaConfiguration : EntityTypeConfiguration<SubCategoria>
    {
        public SubCategoriaConfiguration()
        {
            HasKey(c => c.SubCategoriaId);

            HasRequired(c => c.Categoria)
                .WithMany()
                .HasForeignKey(c => c.CategoriaId);                
        }
    }
}
