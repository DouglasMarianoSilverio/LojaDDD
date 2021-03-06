﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LojaDDD.Domain.Entities;

namespace LojaDDD.MVC.ViewModels
{
    public class VendaViewModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Cliente")]
        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }

        [DisplayName("Data da Venda")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataVenda { get; set; }

        [DisplayName("Valor total")]
        public Decimal? ValorTotal {
           get { return ProdutosVenda.Sum(pv => pv.ValorUnitario * pv.Quantidade  ); }
            
        }
        public virtual IEnumerable<ProdutoVenda> ProdutosVenda { get; set; }
    }
}   