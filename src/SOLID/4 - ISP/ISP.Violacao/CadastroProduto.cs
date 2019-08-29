using System;

namespace SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto não tem e-mail, o que eu faço agora???
            throw new NotImplementedException("Esse método não serve pra nada");
        }

        public void SalvarBanco()
        {
            // Insert tabela Produto
        }

        public void ValidarDados()
        {
            // Validar valor
        }
    }
}
