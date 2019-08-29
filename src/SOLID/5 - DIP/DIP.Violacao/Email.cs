namespace SOLID.DIP.Violacao
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar() => Endereco.Contains("@");
    }
}
