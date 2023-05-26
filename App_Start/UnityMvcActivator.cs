using System.Linq;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NydusPL.UnityMvcActivator), nameof(NydusPL.UnityMvcActivator.Start))]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(NydusPL.UnityMvcActivator), nameof(NydusPL.UnityMvcActivator.Shutdown))]

namespace NydusPL
{
    /// <summary>
    /// Provides the bootstrapping for integrating Unity with ASP.NET MVC.
    /// </summary>
    public static class UnityMvcActivator
    {
        private static readonly IUnityContainer _container;

        static UnityMvcActivator()
        {
            _container = new UnityContainer();
            // Configure a injeção de dependência aqui
            // Exemplo: _container.RegisterType<IMyService, MyService>();
        }

        public static IUnityContainer Container
        {
            get { return _container; }
        }
        /// <summary>
        /// Integrates Unity when the application starts.
        /// </summary>
        public static void Start()
        {
            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(UnityMvcActivator.Container));

            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityMvcActivator.Container));

            // TODO: Uncomment if you want to use PerRequestLifetimeManager
            // Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));
        }

        /// <summary>
        /// Disposes the Unity container when the application is shut down.
        /// </summary>
        public static void Shutdown()
        {
            UnityMvcActivator.Container.Dispose();
        }
    }
}
