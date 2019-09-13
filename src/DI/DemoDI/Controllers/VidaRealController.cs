using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class VidaRealController : Controller
    {
        public VidaRealController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        private readonly IClienteService _clienteService;

        public void Index()
        {
            _clienteService.AdicionarCliente(new Cliente());
        }
    }
}
