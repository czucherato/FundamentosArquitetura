using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Eletrodomestico
    {
        public Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        private readonly string _nome;

        private readonly int _voltagem;

        public abstract void Ligar();

        public abstract void Desligar();

        public virtual void Testar()
        {
            Ligar();
            Desligar();
        }
    }
}
