namespace DesignPatterns.Domain
{
    public class Pagamento
    {
        public string Status { get; set; }

        public decimal Valor { get; set; }

        public MeioPagamento MeioPagamento { get; set; }

        //Possíveis meios de pagamento implementados direto
        //na classe pagamento por brevidade de eemplo

        public string CartaoCredito { get; set; }

        public string LinhaDigitavelBoleto { get; set; }

        public string ConfirmacaoTransferencia { get; set; }
    }
}
