using System;

namespace SOLID.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int largura, int altura)
            : base(largura, altura)
        {
            if (largura != altura) throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
