using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using LogAnalysis.MongoDB.Web.Interfaces;
using LogAnalysis.MongoDB.Contract.Common;

namespace LogAnalysis.MongoDB.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("log4net.config")));

            var builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerRequest();

            RegisterService(builder);

            builder.RegisterModule(new LoggingModule());

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private ContainerBuilder RegisterService(ContainerBuilder builder)
        {
            var baseType = typeof(IDependency);
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                   .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
            return builder;
        }
    }
}
