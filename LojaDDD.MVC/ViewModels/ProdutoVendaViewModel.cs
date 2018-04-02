using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaDDD.MVC.ViewModels
{
    public class ProdutoVendaViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Selecione uma venda.")]
        public int VendaId { get; set; }
        public virtual VendaViewModel Venda { get; set; }
        
        [DisplayName("Produto")]
        [Required(ErrorMessage = "Selecione um produto.")]
        public int ProdutoId { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }

        [Required(ErrorMessage = "Defina a quantidade do Produto.")]
        [Range(typeof(int),"0","999" )]
        public int Quantidade { get; set; }

        [DisplayName("Valor Un.")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Informe o valor unitario do produto.")]
        [Range(typeof(decimal), "0", "99999999999")]
        public Decimal ValorUnitario { get; set; }

        [DisplayName("Valor Total")]
        [DataType(DataType.Currency)]
        public Decimal ValorTotal { get; set; }
    }
}