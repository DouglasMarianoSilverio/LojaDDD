using System;
using System.ComponentModel.DataAnnotations;

namespace LojaDDD.Domain.Entities
{
    public class ProdutoVenda
    {
        [Key]
        public int Id { get; set; }
        public int VendaId { get; set; }
        public virtual Venda Venda { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }

}
