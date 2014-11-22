using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace Ticy.Web
{
    public class ServiceConfig
    {
        public static void RegisterDependencies(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new TicyModule());

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);

            var container = builder.Build();
            
            // web api resolver
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // mvc resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}