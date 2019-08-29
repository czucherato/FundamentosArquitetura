namespace SOLID.OCP.Solucao.ExtensionMethods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Lógica de negócio para débito de conta poupança
            return debitoConta.FormatarTransacao();
        }
    }
}
