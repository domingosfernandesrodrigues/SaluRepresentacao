using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class RemuneracaoConfiguration : EntityTypeConfiguration<Remuneracao>
    {
        public RemuneracaoConfiguration()
        {
            HasKey(f => f.RemuneracaoId);

            HasRequired(p => p.Funcionario)
                .WithMany()
                .HasForeignKey(p => p.FuncionarioId);


        }
    }
}
