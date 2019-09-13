using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private readonly IServiceProvider _serviceProvider;

        public void Index()
        {
            _serviceProvider.GetRequiredService<IClienteService>().AdicionarCliente(new Cliente());
        }
    }
}
