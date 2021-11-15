using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.EntityConfig
{
    public class UnidadeMedidaConfiguration : EntityTypeConfiguration<UnidadeMedida>
    {
        public UnidadeMedidaConfiguration()
        {
            HasKey(c => c.UnidadeMedidaId);

        }
    }
}
