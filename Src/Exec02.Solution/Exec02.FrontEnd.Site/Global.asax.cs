using Autofac;
using Autofac.Integration.Mvc;
using Exec02.FrontEnd.Application.News;
using Exec02.FrontEnd.Site.Controllers;
using Exec02.FrontEnd.Domain.News;
using Exec02.FrontEnd.Domain.Interfaces;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Exec02.FrontEnd.Infra.Data.Repositories;
using Exec02.FrontEnd.Infra.Data.EFModels;

namespace Exec02.FrontEnd.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(HomeController).Assembly);
            builder.RegisterType<HotNewsApi>().As<IHotNewsApi>();
            builder.RegisterType<NewsApi>().As<INewsApi>();
            builder.RegisterType<NewsService>().As<INewsService>();
            builder.RegisterType<NewsRepository>().As<INewsRepository>();
            builder.RegisterType<ErpDbContext>().AsSelf();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
