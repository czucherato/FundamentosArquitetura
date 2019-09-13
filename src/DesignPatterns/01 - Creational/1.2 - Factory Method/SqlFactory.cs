namespace DesignPatterns.FactoryMethod
{
    //Concrete creator
    public class SqlFactory : DbFactory
    {
        //Factory method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
