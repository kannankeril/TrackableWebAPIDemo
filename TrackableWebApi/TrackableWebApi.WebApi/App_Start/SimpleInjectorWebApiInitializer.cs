using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using TrackableWebApi.WebApi;
using TrackableWebApi.Service.EF.Contexts;
using TrackableWebApi.Service.EF.Repositories;
using TrackableWebApi.Service.EF.UnitsOfWork;
using TrackableWebApi.Service.Persistence.Repositories;
using TrackableWebApi.Service.Persistence.UnitsOfWork;

[assembly: WebActivator.PostApplicationStartMethod(typeof(SimpleInjectorWebApiInitializer), "Initialize")]

namespace TrackableWebApi.WebApi
{
    public static class SimpleInjectorWebApiInitializer
    {
        public static void Initialize()
        {
            // Create IoC container
            var container = new Container();

            // Register dependencies
            InitializeContainer(container);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            // Verify registrations
            container.Verify();

            // Set Web API dependency resolver
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            container.RegisterWebApiRequest<INorthwindContext, NorthwindContext>();
            container.RegisterWebApiRequest<INorthwindUnitOfWork, NorthwindUnitOfWork>();
            container.RegisterWebApiRequest<ICustomerRepository, CustomerRepository>();
            container.RegisterWebApiRequest<IOrderRepository, OrderRepository>();
        }
    }
}