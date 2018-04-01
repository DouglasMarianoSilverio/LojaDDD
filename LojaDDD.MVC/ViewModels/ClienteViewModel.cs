using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LojaDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150,ErrorMessage ="Maximo {0} caracteres")]
        [MinLength(2,ErrorMessage ="Minimo {0} caracteres")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo data de nascimento")]
        [DisplayName("Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Idade")]
        public int? Idade
        {
            get
            {
                int age = DateTime.Now.Year - DataNascimento.Year;

                if (DateTime.Now.Month < DataNascimento.Month ||
                    (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                    age--;

                return age;
            }
        }


        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(9, ErrorMessage = "Minimo {0} caracteres")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha um e-mail valido")]
        [DisplayName("E-Mail")]
        public String Email { get; set; }

        public String Telefone { get; set; }

        public virtual IEnumerable<VendaViewModel> Vendas { get; set; }

        //public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}