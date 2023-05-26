using System.Web.Mvc;

using NydusPL.Repository;
using NydusPL.Service;

using Unity;
using Unity.AspNet.Mvc;

public static class UnityConfig
{
    public static IUnityContainer Container { get; internal set; }

    public static void RegisterComponents()
    {
        var container = new UnityContainer();

        // Registre os repositórios
        container.RegisterType<IEmpresaRepository, EmpresaRepository>();
        container.RegisterType<ICargoRepository, CargoRepository>();

        // Registre os serviços
        container.RegisterType<IReceitaWSService, ReceitaWSService>();
        container.RegisterType<IEmpresaService, EmpresaService>();
        container.RegisterType<ICargoService, CargoService>();

        // Resolva as dependências do controlador usando o Unity Container
        DependencyResolver.SetResolver(new UnityDependencyResolver(container));
    }
}
