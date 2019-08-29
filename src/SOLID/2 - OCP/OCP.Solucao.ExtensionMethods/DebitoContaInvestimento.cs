namespace SOLID.OCP.Solucao.ExtensionMethods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Lógica de negócio para débito de conta investimento
            return debitoConta.FormatarTransacao();
        }
    }
}
