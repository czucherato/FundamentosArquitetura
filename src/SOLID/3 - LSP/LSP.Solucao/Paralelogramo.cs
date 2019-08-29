namespace SOLID.LSP.Solucao
{
    public class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            Altura = largura;
            Largura = altura;
        }

        public double Altura { get; set; }

        public double Largura { get; set; }

        public double Area => Altura * Largura;
    }
}
