namespace DesignPatterns.Adapter
{
    //Client
    public class TransacaoService
    {
        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        private readonly ILogger _logger;

        public void RealizarTransacao()
        {
            // Transação
            _logger.Log("Transação realizada");
        }
    }
}
