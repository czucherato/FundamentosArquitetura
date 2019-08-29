namespace SOLID.OCP.Solucao.ExtensionMethods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Lógica de negócio para débito de conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
