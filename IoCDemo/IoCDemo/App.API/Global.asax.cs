using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using App.Data.Repository;
using App.Data.Infrastructure;
using App.Service;

namespace App.API
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            // Configure Autofac with WebAPI
            var builder = new ContainerBuilder();
            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();


            builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>().InstancePerRequest();

            // Register your repositories all at once using assembly scanning
            builder.RegisterAssemblyTypes(typeof(CustomerRepository).Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(CustomerService).Assembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();

            // Register your Web API controllers all at once using assembly scanning
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}