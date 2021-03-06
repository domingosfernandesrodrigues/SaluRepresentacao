using AutoMapper;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Compra, CompraViewModel>();
            Mapper.CreateMap<Fornecedor, FornecedorViewModel>();
            Mapper.CreateMap<ItensCompra, ItensCompraViewModel>();
            Mapper.CreateMap<ItensVenda, ItensVendaViewModel>();           
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<SubCategoria, SubCategoriaViewModel>();
            Mapper.CreateMap<TipoPagamento, TipoPagamentoViewModel>();
            Mapper.CreateMap<UnidadeMedida, UnidadeMedidaViewModel>();
            Mapper.CreateMap<Venda, VendaViewModel>();
            Mapper.CreateMap<Funcionario, FuncionarioViewModel>();
            Mapper.CreateMap<Cargo, CargoViewModel>();
            Mapper.CreateMap<Alimentacao, AlimentacaoViewModel>();
            Mapper.CreateMap<Remuneracao, RemuneracaoViewModel>();
            Mapper.CreateMap<Empresa, EmpresaViewModel>();
            Mapper.CreateMap<Veiculo, VeiculoViewModel>();
            Mapper.CreateMap<ManutencaoVeiculo, ManutencaoVeiculoViewModel>();
            Mapper.CreateMap<DevolucaoCompras, DevolucaoComprasViewModel>();
        }
    }
}