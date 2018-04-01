using System;
using System.Collections.Generic;

namespace LojaDDD.Domain.Entities
{
    public class Produto
    {
        public int ID { get; set; }
        public String Nome { get; set; }

        public virtual IList<ProdutoVenda> ProdutosVenda { get; set; }
        //public int ClienteId { get; set; }
        //public virtual Cliente Cliente { get; set; }
    }
}
