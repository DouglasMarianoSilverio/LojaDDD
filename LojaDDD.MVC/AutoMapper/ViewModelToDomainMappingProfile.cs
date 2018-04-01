using AutoMapper;
using LojaDDD.Domain.Entities;
using LojaDDD.MVC.ViewModels;


namespace LojaDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile

    {
        // Não usar este override na versão 4.x e superiores
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<VendaViewModel, Venda>();
            Mapper.CreateMap<ProdutoVendaViewModel, ProdutoVenda>();
        }
    }
}