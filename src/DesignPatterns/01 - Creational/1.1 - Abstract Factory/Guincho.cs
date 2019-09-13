using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract product
    public abstract class Guincho
    {
        public Guincho(Porte porte)
        {
            this.Porte = porte;
        }

        public Porte Porte { get; set; }

        public abstract void Socorrer(Veiculo veiculo);
    }

    // Produto Concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) :base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorreno Carro Pequeno - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorreno Carro Médio - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorreno Carro Grande - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch(porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException("pp");
            }
        }
    }

}
