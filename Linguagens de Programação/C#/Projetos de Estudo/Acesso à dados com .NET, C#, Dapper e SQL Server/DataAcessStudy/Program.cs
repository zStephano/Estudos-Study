// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

const string connectionStringSqlServer =
    "Server=localhost,1433;Database=StephanoIO;User ID=sa;Password=GStephano@1998*;TrustServerCertificate=true";

//const string connectionStringPostgreSql =
//    "Server=localhost,5432;Database=pssql;User ID=pssql;Password=GStephano@1998*;";

using (var connectionSqlServer = new SqlConnection(connectionStringSqlServer))
{
    Console.WriteLine("Conectado");
    connectionSqlServer.Open();

    using (var command = new SqlCommand())
    {
        command.Connection = connectionSqlServer;
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "SELECT [Id], [Title] FROM [Category]";

        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
        }
    }
}

//// Study PostgreSQL connection -- WORKING!!!
//using (var connectionPostgreSql = new SqlConnection(connectionStringPostgreSql))
//{
//    Console.WriteLine("Conectado");
//    connectionPostgreSql.Open();

//    using (var command = new SqlCommand())
//    {
//        command.Connection = connectionPostgreSql;
//        command.CommandType = System.Data.CommandType.Text;
//        command.CommandText = "SELECT [Id], [Title] FROM [Category]";

//        var reader = command.ExecuteReader();
//        while (reader.Read())
//        {
//            Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
//        }
//    }
}