[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ControleDeEstoque.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ControleDeEstoque.App_Start.NinjectWebCommon), "Stop")]

namespace ControleDeEstoque.App_Start
{
    using System;
    using System.Web;
    using ControleDeEstoque.Application;
    using ControleDeEstoque.Application.Interface;
    using ControleDeEstoque.Domain.Interfaces;
    using ControleDeEstoque.Domain.Interfaces.Services;
    using ControleDeEstoque.Domain.Services;
    using ControleDeEstoque.Infra.Data.Repositories;
    using ControleDeEstoque.Infra.Data;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            kernel.Bind<ICategoriaAppService>().To<CategoriaAppService>();
            kernel.Bind<ICompraAppService>().To<CompraAppService>();
            kernel.Bind<IFornecedorAppService>().To<FornecedorAppService>();
            kernel.Bind<IItensCompraAppService>().To<ItensCompraAppService>();
            kernel.Bind<IItensVendaAppService>().To<ItensVendaAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            kernel.Bind<ISubCategoriaAppService>().To<SubCategoriaAppService>();
            kernel.Bind<ITipoPagamentoAppService>().To<TipoPagamentoAppService>();
            kernel.Bind<IUnidadeMedidaAppService>().To<UnidadeMedidaAppService>();
            kernel.Bind<IVendaAppService>().To<VendaAppService>();
            kernel.Bind<IFuncionarioAppService>().To<FuncionarioAppService>();
            kernel.Bind<ICargoAppService>().To<CargoAppService>();
            kernel.Bind<IAlimentacaoAppService>().To<AlimentacaoAppService>();
            kernel.Bind<IRemuneracaoAppService>().To<RemuneracaoAppService>();
            kernel.Bind<IEmpresaAppService>().To<EmpresaAppService>();
            kernel.Bind<IVeiculoAppService>().To<VeiculoAppService>();
            kernel.Bind<IManutencaoVeiculoAppService>().To<ManutencaoVeiculoAppService>();
            kernel.Bind<IDevolucaoComprasAppService>().To<DevolucaoComprasAppService>();
            

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<ICategoriaService>().To<CategoriaService>();
            kernel.Bind<ICompraService>().To<CompraService>();
            kernel.Bind<IFornecedorService>().To<FornecedorService>();
            kernel.Bind<IItensCompraService>().To<ItensCompraService>();
            kernel.Bind<IItensVendaService>().To<ItensVendaService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<ISubCategoriaService>().To<SubCategoriaService>();
            kernel.Bind<ITipoPagamentoService>().To<TipoPagamentoService>();
            kernel.Bind<IUnidadeMedidaService>().To<UnidadeMedidaService>();
            kernel.Bind<IVendaService>().To<VendaService>();
            kernel.Bind<IFuncionarioService>().To<FuncionarioService>();
            kernel.Bind<ICargoService>().To<CargoService>();
            kernel.Bind<IAlimentacaoService>().To<AlimentacaoService>();
            kernel.Bind<IRemuneracaoService>().To<RemuneracaoService>();
            kernel.Bind<IEmpresaService>().To<EmpresaService>();
            kernel.Bind<IVeiculoService>().To<VeiculoService>();
            kernel.Bind<IManutencaoVeiculoService>().To<ManutencaoVeiculoService>();
            kernel.Bind<IDevolucaoComprasService>().To<DevolucaoComprasService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<ICategoriaRepository>().To<CategoriaRepository>();
            kernel.Bind<ICompraRepository>().To<CompraRepository>();
            kernel.Bind<IFornecedorRepository>().To<FornecedorRepository>();
            kernel.Bind<IItensCompraRepository>().To<ItensCompraRepository>();
            kernel.Bind<IItensVendaRepository>().To<ItensVendaRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
            kernel.Bind<ISubCategoriaRepository>().To<SubCategoriaRepository>();
            kernel.Bind<ITipoPagamentoRepository>().To<TipoPagamentoRepository>();
            kernel.Bind<IUnidadeMedidaRepository>().To<UnidadeMedidaRepository>();
            kernel.Bind<IVendaRepository>().To<VendaRepository>();
            kernel.Bind<IFuncionarioRepository>().To<FuncionarioRepository>();
            kernel.Bind<ICargoRepository>().To<CargoRepository>();
            kernel.Bind<IAlimentacaoRepository>().To<AlimentacaoRepository>();
            kernel.Bind<IRemuneracaoRepository>().To<RemuneracaoRepository>();
            kernel.Bind<IEmpresaRepository>().To<EmpresaRepository>();
            kernel.Bind<IVeiculoRepository>().To<VeiculoRepository>();
            kernel.Bind<IManutencaoVeiculoRepository>().To<ManutencaoVeiculoRepository>();
            kernel.Bind<IDevolucaoComprasRepository>().To<DevolucaoComprasRepository>();
        }        
    }
}
