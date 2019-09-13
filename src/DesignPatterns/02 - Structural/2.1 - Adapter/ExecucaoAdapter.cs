namespace DesignPatterns.Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentroLogPadrao = new TransacaoService(new Logger());
            pagamentroLogPadrao.RealizarTransacao();

            var pagamentoLogCustomizado = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustomizado.RealizarTransacao();
        }
    }
}
