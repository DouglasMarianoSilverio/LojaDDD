using System.Data.Entity.ModelConfiguration;
using LojaDDD.Domain.Entities;

namespace LojaDDD.Infra.Data.EntityConfig
{
    public class ProdutoVendaConfiguration : EntityTypeConfiguration<ProdutoVenda>
    {
        public ProdutoVendaConfiguration()
        {
            
            Property(pv => pv.Quantidade)
                .IsRequired();
            Property(pv => pv.ValorUnitario).IsRequired();

        }
    }
}
