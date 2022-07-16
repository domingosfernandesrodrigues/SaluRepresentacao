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
        public DbSet<Venda> Venda { get; set; }        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItensVenda> ItensVenda { get; set; }
        public DbSet<ItensCompra> ItensCompra { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Remuneracao> Remuneracao { get; set; }
        public DbSet<Alimentacao> Alimentacao { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<ManutencaoVeiculo> ManutencaoVeiculo { get; set; }
        public DbSet<DevolucaoCompras> DevolucaoCompras { get; set; }


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
            modelBuilder.Configurations.Add(new VendaConfiguration());            
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new UnidadeMedidaConfiguration());
            modelBuilder.Configurations.Add(new SubCategoriaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new ItensVendaConfiguration());
            modelBuilder.Configurations.Add(new ItensCompraConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new CargoConfiguration());
            modelBuilder.Configurations.Add(new RemuneracaoConfiguration());
            modelBuilder.Configurations.Add(new AlimentacaoConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new VeiculoConfiguration());
            modelBuilder.Configurations.Add(new ManutencaoVeiculoConfiguration());
            modelBuilder.Configurations.Add(new DevolucaoComprasConfiguration());
            
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateOn") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateOn").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreateOn").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
        
    }
}
