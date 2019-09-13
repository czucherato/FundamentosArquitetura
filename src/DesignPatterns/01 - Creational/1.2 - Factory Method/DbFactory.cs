using System;

namespace DesignPatterns.FactoryMethod
{
    //Abstract creator
    public abstract class DbFactory
    {
        //Factory method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(Database database)
        {
            if (database == FactoryMethod.Database.Oracle)
                return new SqlFactory();
            //if (database == FactoryMethod.Database.Oracle)
            //    return OracleFactory();

            throw new ApplicationException("Banco de dados não reconhecido.");
        }
    }
}
