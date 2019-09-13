namespace DesignPatterns.Domain
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
