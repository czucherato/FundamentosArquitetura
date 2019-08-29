namespace OOP
{
    // Poli-morfismo
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        public CafeteiraExpressa()
            : base("Padrão", 220) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            AquecerAgua();
            MoerGraos();
            // etc...
        }

        public override void Ligar()
        {
            // Verificar recipiente de água
        }

        public override void Desligar()
        {
            // Resfriar aquecedor
        }

        public override void Testar()
        {
            Ligar();
            PrepararCafe();
            Desligar();
        }
    }
}
