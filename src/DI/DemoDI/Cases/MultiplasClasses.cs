namespace DemoDI.Cases
{

    public interface IService
    {
        string Retorno();
    }

    public class ServiceA : IService
    {
        public string Retorno() => "A";
    }

    public class ServiceB : IService
    {
        public string Retorno() => "B";
    }

    public class ServiceC : IService
    {
        public string Retorno() => "C";
    }
}
