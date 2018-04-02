using System;
using System.Collections.Generic;

namespace LojaDDD.Domain.Entities
{
    public class Cliente
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public String CPF { get; set; }
        public String Email { get; set; }

        public String Telefone { get; set; }

        public virtual IList<Venda> Vendas { get; set; }
        
        public int Idade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                idade--;

            return idade;
        }



    }
}
