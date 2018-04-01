using System;
using System.Collections.Generic;

namespace LojaDDD.Domain.Entities
{
    public class Venda
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public virtual  Cliente Cliente { get; set; }

        public DateTime DataVenda { get; set; }

        public virtual  IList<ProdutoVenda>  ProdutosVenda { get; set; }


    }
}
