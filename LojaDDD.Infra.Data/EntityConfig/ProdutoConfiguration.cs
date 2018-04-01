using System.Data.Entity.ModelConfiguration;
using LojaDDD.Domain.Entities;

namespace LojaDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>

    {
        public ProdutoConfiguration() {
            HasKey(p => p.ID);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            HasMany(p => p.ProdutosVenda)
                .WithRequired(pv=>pv.Produto)
                .HasForeignKey(pv=>pv.ProdutoId);

            /* Property(p => p.Valor)
                .IsRequired();}

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId); */


        }
    }
}
