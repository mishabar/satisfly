using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using EliteRoute.Data.Repositories;
using EliteRoute.Services;
using MongoDB.Driver;

namespace EliteRoute.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            // initializing dependency injection  container
            var builder = new ContainerBuilder();

            // registrating all the existing controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            MongoClient mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDB"]);
            builder.Register(c => mongoClient.GetServer().GetDatabase(ConfigurationManager.AppSettings["MongoDB"].Split('/').Last())).AsSelf();

            builder.Register(c => new AccountRepository(c.Resolve<MongoDatabase>())).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.Register(c => new ComplaintRepository(c.Resolve<MongoDatabase>())).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.Register(c => new DataService()).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.Register(c => new AccountService(c.Resolve<IAccountRepository>())).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.Register(c => new ComplaintService(c.Resolve<IComplaintRepository>())).AsImplementedInterfaces().InstancePerLifetimeScope();

            // build the dependencies
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
