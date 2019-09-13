namespace DesignPatterns.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
