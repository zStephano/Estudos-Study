// See https://aka.ms/new-console-template for more information
using Dapper;
using DataAcessStudy.DataAccess;
using DataAcessStudy.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

Console.WriteLine("Hello, World!");

const string connectionStringSqlServer =
    "Server=localhost,1433;Database=StephanoIO;User ID=sa;Password=GStephano@1998*;TrustServerCertificate=true";

//const string connectionStringPostgreSql =
//    "Server=localhost,5432;Database=pssql;User ID=pssql;Password=GStephano@1998*;";

var category = new Category();
category.Id = Guid.NewGuid();
category.Title = "Amazon AWS";
category.Url = "amazon";
category.Description = "Categoria destinada a serviços do AWS";
category.Order = 8;
category.Summary = "AWS Cloud";
category.Featured = false;

var insertSql = @"INSERT INTO 
        Category 
    VALUES (
        @Id 
        @Title, 
        @Url, 
        @Summary, 
        @Order, 
        @Description, 
        @Featured)";


using (var connectionSqlServer = new SqlConnection(connectionStringSqlServer))
{
    Queries.CreateCategory(connectionSqlServer);
    Queries.CreateManyCategory(connectionSqlServer);
    Queries.UpdateCategory(connectionSqlServer);
    Queries.DeleteCategory(connectionSqlServer);
    Queries.ListCategories(connectionSqlServer);
    Queries.GetCategory(connectionSqlServer);
    Queries.ExecuteProcedure(connectionSqlServer);
    Queries.ExecuteReadProcedure(connectionSqlServer);
    Queries.ExecuteScalar(connectionSqlServer);
    Queries.ReadView(connectionSqlServer);
    Queries.OneToOne(connectionSqlServer);
    Queries.OneToMany(connectionSqlServer);
    Queries.QueryMutiple(connectionSqlServer);
    Queries.SelectIn(connectionSqlServer);
    Queries.Like(connectionSqlServer, "backend");
    Queries.Transaction(connectionSqlServer);

}

// Study connection to do a native SqlCommand

//using (var connectionSqlServer = new SqlConnection(connectionStringSqlServer))
//{
//    Console.WriteLine("Conectado");
//    connectionSqlServer.Open();

//    using (var command = new SqlCommand())
//    {
//        command.Connection = connectionSqlServer;
//        command.CommandType = System.Data.CommandType.Text;
//        command.CommandText = "SELECT [Id], [Title] FROM [Category]";

//        var reader = command.ExecuteReader();
//        while (reader.Read())
//        {
//            Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
//        }
//    }
//}

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
//}