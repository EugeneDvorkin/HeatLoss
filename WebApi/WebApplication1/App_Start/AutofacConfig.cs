using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using DependencyResolver;

namespace WebApplication1
{
    public static class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();
            //builder.RegisterAssemblyModules(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("HeatLoss")).ToArray());
            Kernel.Configure(builder);
            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
        //public static void Register(HttpConfiguration config)
        //{
        //    var builder = new ContainerBuilder();

        //    builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        //    builder.RegisterWebApiFilterProvider(config);
        //    builder.RegisterWebApiModelBinderProvider();
        //    builder.RegisterAssemblyModules(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Katla")).ToArray());

        //    config.DependencyResolver = new AutofacWebApiDependencyResolver(builder.Build());
        //}
    }
}