using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class VeiculoConfiguration : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoConfiguration()
        {
            HasKey(p => p.VeiculoId);

            Property(p => p.Marca)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Modelo)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Placa)
                .IsRequired()
                .HasMaxLength(20);

            HasRequired(p => p.Empresa)
               .WithMany()
               .HasForeignKey(p => p.EmpresaId);
        }
    }
}
