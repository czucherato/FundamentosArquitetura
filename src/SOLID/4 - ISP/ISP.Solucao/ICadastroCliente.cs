namespace SOLID.ISP.Solucao
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();

        void EnviarEmail();
    }
}
