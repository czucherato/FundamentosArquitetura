using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    public class ExecucaoAbastractFactory
    {
        public static void Executar()
        {
            var veiculoSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", Porte.Pequeno),
                VeiculoCreator.Criar("Jetta", Porte.Medio),
                VeiculoCreator.Criar("BMW X6", Porte.Grande)
            };

            veiculoSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}
