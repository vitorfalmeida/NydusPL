using System;
using System.Web.Mvc;
using System.Web.Routing;
using NydusPL.Service;
using NydusPL.Repository;
using NydusPL.BD;
using NydusPL.Controllers;

namespace NydusPL
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        private readonly IReceitaWSService _receitaWSService;

        public CustomControllerFactory(IReceitaWSService receitaWSService)
        {
            _receitaWSService = receitaWSService;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType != null)
            {
                if (controllerType == typeof(EmpresaController))
                {
                    var dbContext = new AppDbContext();
                    var empresaRepository = new EmpresaRepository(dbContext);
                    var empresaService = new EmpresaService(empresaRepository, _receitaWSService);
                    return new EmpresaController(empresaService);
                }
                else if (controllerType == typeof(CargoController))
                {
                    var dbContext = new AppDbContext();
                    var cargoRepository = new CargoRepository(dbContext);
                    var cargoService = new CargoService(cargoRepository);
                    return new CargoController(cargoService);
                }
                // Repita o mesmo padrão para outros controllers

                // Se não encontrar um controller correspondente, retorne o controller padrão
                return base.GetControllerInstance(requestContext, controllerType);
            }

            return null;
        }
    }
}
