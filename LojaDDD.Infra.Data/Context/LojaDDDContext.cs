using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using LojaDDD.Domain.Entities;
using LojaDDD.Infra.Data.EntityConfig;
using LojaDDD.Infra.Data.Migrations;

namespace LojaDDD.Infra.Data.Context
{
    public class LojaDDDContext : DbContext

    {
        public LojaDDDContext() : base("LojaDDD")
        {
            //se nao colocar nao aplica a migration no banco
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LojaDDDContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //remover a pruralização do nome da table
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //forçar a atribuir Classe +Id como chave 
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType + "Id")
                .Configure(p => p.IsKey());
            //configurar como varchar em vez de nvarchar
            modelBuilder.Properties<String>()
                .Configure(p => p.HasColumnType("varchar"));
            //configurar como varchar(100) caso nao seja especificado.
            modelBuilder.Properties<String>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new VendaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoVendaConfiguration());

            base.OnModelCreating(modelBuilder);

        }

        public override int SaveChanges()
        {

            //Tratar o campo DataCadastro/Venda
            foreach (var entry in ChangeTracker
                .Entries()
                .Where
                    (entry => entry.Entity.GetType().GetProperty("DataCadastro") != null)
            )
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Property("DataCadastro").IsModified = false;
                        break;
                }
            }

            foreach (var entry in ChangeTracker
                .Entries()
                .Where
                    (entry => entry.Entity.GetType().GetProperty("DataVenda") != null)
            )
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property("DataVenda").CurrentValue = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Property("DataVenda").IsModified = false;
                        break;
                }
            }
            return base.SaveChanges();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ProdutoVenda> ProdutosVenda { get; set; }
    }
}
