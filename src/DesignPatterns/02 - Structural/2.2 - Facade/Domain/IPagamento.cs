namespace DesignPatterns.Domain
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
