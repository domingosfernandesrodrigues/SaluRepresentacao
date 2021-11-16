using AutoMapper;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName 
        {
            get { return "ViewModelToDomainMappings"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<CompraViewModel, Compra>();
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
            Mapper.CreateMap<ItensCompraViewModel, ItensCompra>();
            Mapper.CreateMap<ItensVendaViewModel, ItensVenda>();
            Mapper.CreateMap<ParcelasCompraViewModel, ParcelasCompra>();
            Mapper.CreateMap<ParcelasVendaViewModel, ParcelasVenda>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<SubCategoriaViewModel, SubCategoria>();
            Mapper.CreateMap<TipoPagamentoViewModel, TipoPagamento>();
            Mapper.CreateMap<UnidadeMedidaViewModel, UnidadeMedida>();
            Mapper.CreateMap<VendaViewModel, Venda>();
        }
    }
}