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
            kernel.Bind<IParcelasCompraAppService>().To<ParcelasCompraAppService>();
            kernel.Bind<IParcelasVendaAppService>().To<ParcelasVendaAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            kernel.Bind<ISubCategoriaAppService>().To<SubCategoriaAppService>();
            kernel.Bind<ITipoPagamentoAppService>().To<TipoPagamentoAppService>();
            kernel.Bind<IUnidadeMedidaAppService>().To<UnidadeMedidaAppService>();
            kernel.Bind<IVendaAppService>().To<VendaAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<ICategoriaService>().To<CategoriaService>();
            kernel.Bind<ICompraService>().To<CompraService>();
            kernel.Bind<IFornecedorService>().To<FornecedorService>();
            kernel.Bind<IItensCompraService>().To<ItensCompraService>();
            kernel.Bind<IItensVendaService>().To<ItensVendaService>();
            kernel.Bind<IParcelasCompraService>().To<ParcelasCompraService>();
            kernel.Bind<IParcelasVendaService>().To<ParcelasVendaService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<ISubCategoriaService>().To<SubCategoriaService>();
            kernel.Bind<ITipoPagamentoService>().To<TipoPagamentoService>();
            kernel.Bind<IUnidadeMedidaService>().To<UnidadeMedidaService>();
            kernel.Bind<IVendaService>().To<VendaService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<ICategoriaRepository>().To<CategoriaRepository>();
            kernel.Bind<ICompraRepository>().To<CompraRepository>();
            kernel.Bind<IFornecedorRepository>().To<FornecedorRepository>();
            kernel.Bind<IItensCompraRepository>().To<ItensCompraRepository>();
            kernel.Bind<IItensVendaRepository>().To<ItensVendaRepository>();
            kernel.Bind<IParcelasCompraRepository>().To<ParcelasCompraRepository>();
            kernel.Bind<IParcelasVendaRepository>().To<ParcelasVendaRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
            kernel.Bind<ISubCategoriaRepository>().To<SubCategoriaRepository>();
            kernel.Bind<ITipoPagamentoRepository>().To<TipoPagamentoRepository>();
            kernel.Bind<IUnidadeMedidaRepository>().To<UnidadeMedidaRepository>();
            kernel.Bind<IVendaRepository>().To<VendaRepository>();
        }        
    }
}
