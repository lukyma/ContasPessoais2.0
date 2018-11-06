[assembly: WebActivator.PostApplicationStartMethod(typeof(ContasPessoais2._0.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]
namespace ContasPessoais2._0.App_Start
{
    using System.Web.Http;
    using ContasPessoais2._0.IoC;
    using ContasPessoais2._0.IoC.Modules;
    using FluentValidation.WebApi;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using SimpleInjector.Lifestyles;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            AppServiceModule.Register(container);
            ServiceModule.Register(container);
            RepositoryModule.Register(container);
            DataModule.Register(container);
            ValidatorModule.Register(container);
            //FluentValidationModelValidatorProvider.Configure(GlobalConfiguration.Configuration, provider =>
            //{
            //    provider.ValidatorFactory = new ApplicationValidatorFactory(container);
            //});
        }
    }
}