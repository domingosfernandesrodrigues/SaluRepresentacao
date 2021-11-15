using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(p => p.ClienteId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Sobrenome)
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
