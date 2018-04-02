using System.Data.Entity.ModelConfiguration;
using LojaDDD.Domain.Entities;

namespace LojaDDD.Infra.Data.EntityConfig
{
    public class VendaConfiguration : EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {
            Property(v=>v.ClienteId)
                .IsRequired();
            
            HasMany(v => v.ProdutosVenda)
                .WithRequired(pv=>pv.Venda)
                .HasForeignKey(pv=>pv.VendaId)
                .WillCascadeOnDelete(true);
        }
    }
}
