namespace SOLID.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        public ClienteService(
            IClienteRepository clienteRepository,
            IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _emailService = emailService;
        }

        private readonly IClienteRepository _clienteRepository;

        private readonly IEmailService _emailService;

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar()) return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);
            _emailService.Enviar("empresa@empresa.com.br", cliente.Email.Endereco, "", "");
            return "Cliente cadastrado com sucesso";
        }
    }
}
