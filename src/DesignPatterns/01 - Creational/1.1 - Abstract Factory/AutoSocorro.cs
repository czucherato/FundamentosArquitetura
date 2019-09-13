using System;

namespace DesignPatterns.AbstractFactory
{
    //Client class
    public class AutoSocorro
    {
        public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        private readonly Veiculo _veiculo;

        private readonly Guincho _guincho;

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            switch(veiculo.Porte)
            {
                case Porte.Pequeno:
                    return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);
                case Porte.Medio:
                    return new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo);
                case Porte.Grande:
                    return new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }
    }
}
