using System;

namespace DemoDI.Cases
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public DateTime DataCadastro { get; set; }
    }

    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            // Faz algo
        }
    }

    public interface IClienteService
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteService : IClienteService
    {
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        private IClienteRepository _clienteRepository;

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}
