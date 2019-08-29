namespace OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            CafeteiraExpressa expresso = new CafeteiraExpressa();
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();
        }
    }
}
