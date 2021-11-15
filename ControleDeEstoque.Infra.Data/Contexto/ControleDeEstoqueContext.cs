using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Contexto
{
    public class ControleDeEstoqueContext : DbContext
    {
        public ControleDeEstoqueContext()
            : base("SaluRepresentacao")
        {

        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<TipoPagamento> TipoPagamento { get; set; }
        public DbSet<ParcelasCompra> ParcelasCompra { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<ParcelasVenda> ParcelasVenda { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItensVenda> ItensVenda { get; set; }
        public DbSet<ItensCompra> ItensCompra { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new FornecedorConfiguration());
            modelBuilder.Configurations.Add(new CompraConfiguration());
            modelBuilder.Configurations.Add(new TipoPagamentoConfiguration());
            modelBuilder.Configurations.Add(new ParcelasCompraConfiguration());
            modelBuilder.Configurations.Add(new VendaConfiguration());
            modelBuilder.Configurations.Add(new ParcelasVendaConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new UnidadeMedidaConfiguration());
            modelBuilder.Configurations.Add(new SubCategoriaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new ItensVendaConfiguration());
            modelBuilder.Configurations.Add(new ItensCompraConfiguration());
            
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
