using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class AlimentacaoConfiguration : EntityTypeConfiguration<Alimentacao>
    {
        public AlimentacaoConfiguration()
        {
            HasKey(f => f.AlimentacaoId);

            HasRequired(p => p.Funcionario)
                .WithMany()
                .HasForeignKey(p => p.FuncionarioId);


        }
    }
}
