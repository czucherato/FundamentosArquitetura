using System;

namespace OOP
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;
            return idade;
        }
    }
}
