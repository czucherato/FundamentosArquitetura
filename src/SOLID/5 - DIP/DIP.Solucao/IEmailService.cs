namespace SOLID.DIP.Solucao
{
    public interface IEmailService
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
