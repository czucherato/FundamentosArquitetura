using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class GenericController : Controller
    {
        public GenericController(IGenericRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        private readonly IGenericRepository<Cliente> _clienteRepository;

        public void Index()
        {
            _clienteRepository.Adicionar(new Cliente());
        }
    }
}
