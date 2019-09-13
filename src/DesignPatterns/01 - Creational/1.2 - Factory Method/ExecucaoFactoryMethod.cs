using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(Database.SqlServer)
                .CreateConnector("sqlServerConnectionString")
                .Connect();

            sqlCn.ExecuteCommand("select * from tabelaSql");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(Database.Oracle)
                .CreateConnector("oracleConnectionString")
                .Connect();

            sqlCn.ExecuteCommand("select * from tabelaOracle");
            sqlCn.Close();
        }
    }
}
