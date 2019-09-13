using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            serviceProvider.GetRequiredService<IClienteService>().AdicionarCliente(new Cliente());
        }
    }
}
