using AutoMapper;
using LojaDDD.Domain.Entities;
using LojaDDD.MVC.ViewModels;

namespace LojaDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
         // Não realizar este override na versão 4.x e superiores

        public override string ProfileName

        {

            get { return "DomainToViewModelMappings"; }

        }

 

        protected override void Configure()

        {

            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Venda, VendaViewModel>();
            Mapper.CreateMap<ProdutoVenda, ProdutoVendaViewModel>();
        }

    }
}