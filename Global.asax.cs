using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using NydusPL;

using NydusPL.Service;
using NydusPL.Repository;
using NydusPL.BD;
using NydusPL.Controllers;
using Unity.AspNet.Mvc;

namespace NydusPL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Configure o Unity Container
            var container = new UnityContainer();

            // Registre os servi�os e reposit�rios no Unity Container
            container.RegisterType<IReceitaWSService, ReceitaWSService>();
            container.RegisterType<IAppDbContext, AppDbContext>();
            container.RegisterType<IEmpresaRepository, EmpresaRepository>();
            container.RegisterType<IEmpresaService, EmpresaService>();
            container.RegisterType<ICargoRepository, CargoRepository>();
            container.RegisterType<ICargoService, CargoService>();
            // Registre outros servi�os e reposit�rios conforme necess�rio

            // Configure o UnityDependencyResolver para resolver as depend�ncias nos controladores
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // Defina o CustomControllerFactory como o ControllerFactory usado pela aplica��o
            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory(container.Resolve<IReceitaWSService>()));
        }
    }
}
