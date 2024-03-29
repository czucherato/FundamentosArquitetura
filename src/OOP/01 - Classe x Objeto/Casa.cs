﻿namespace OOP
{
    // Definição de Classe
    public class Casa
    {
        public int TamanhoM2 { get; set; }

        public int Andares { get; set; }

        public decimal Valor { get; set; }

        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        // Definição de Objeto
        public Objeto()
        {
            Casa casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}
