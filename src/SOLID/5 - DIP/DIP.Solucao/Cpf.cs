namespace SOLID.DIP.Solucao
{
    public class Cpf
    {
        public string Numero { get; set; }

        public bool Validar() => Numero.Length == 11;
    }
}
