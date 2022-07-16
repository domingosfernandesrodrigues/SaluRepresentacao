using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class ManutencaoVeiculoConfiguration : EntityTypeConfiguration<ManutencaoVeiculo>
    {
        public ManutencaoVeiculoConfiguration()
        {
            HasKey(p => p.ManutencaoVeiculoId);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(300);            

            HasRequired(p => p.Veiculo)
               .WithMany()
               .HasForeignKey(p => p.VeiculoId);
        }
    }
}
