using ControleDeEstoque.AutoMapper;
using ControleDeEstoque.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ControleDeEstoque
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();
            //Database.SetInitializer<ControleDeEstoqueContext>(new DropCreateDatabaseIfModelChanges<ControleDeEstoqueContext>());
            //Database.SetInitializer<ControleDeEstoqueContext>(null);
        }
    }
}
