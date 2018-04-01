using System.Data.Entity.ModelConfiguration;
using LojaDDD.Domain.Entities;

namespace LojaDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration() {
            HasKey(c => c.ID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
            
            Property(c => c.Email)
                .IsRequired();

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.CPF)
                .IsRequired();

            HasMany(c => c.Vendas);
        }
    }
}
