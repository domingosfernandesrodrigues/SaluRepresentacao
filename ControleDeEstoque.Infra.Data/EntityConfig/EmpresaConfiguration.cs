using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            HasKey(p => p.EmpresaId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.NomeFantasia)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.razaoSocial)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Endereco)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Email)
                .IsRequired();

        }
    }
}
