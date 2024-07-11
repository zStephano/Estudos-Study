// See https://aka.ms/new-console-template for more information
using Dapper;
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
    // CreateCategory(connectionSqlServer);
    // UpdateCategory(connectionSqlServer);
    // DeleteCategory(connectionSqlServer);
    // ListCategories(connectionSqlServer);
    GetCategory(connectionSqlServer);

}

static void ListCategories(SqlConnection connection)
{
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
    foreach (var item in categories)
    {
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
}

static void GetCategory(SqlConnection connection)
{
    var category = connection
        .QueryFirstOrDefault<Category>(
            "SELECT TOP 1 [Id], [Title] FROM [Category] WHERE [Id]=@id",
            new
            {
                id = "af3407aa-11ae-4621-a2ef-2028b85507c4"
            });
    Console.WriteLine($"{category.Id} - {category.Title}");

}

static void CreateCategory(SqlConnection connection)
{
    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon AWS";
    category.Url = "amazon";
    category.Description = "Categoria destinada a serviços do AWS";
    category.Order = 8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    var insertSql = @"INSERT INTO 
                    [Category] 
                VALUES(
                    @Id, 
                    @Title, 
                    @Url, 
                    @Summary, 
                    @Order, 
                    @Description, 
                    @Featured)";

    var rows = connection.Execute(insertSql, new
    {
        category.Id,
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured
    });
    Console.WriteLine($"{rows} linhas inseridas");
}

static void UpdateCategory(SqlConnection connection)
{
    var updateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@id";
    var rows = connection.Execute(updateQuery, new
    {
        id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
        title = "Frontend 2021"
    });

    Console.WriteLine($"{rows} registros atualizadas");
}

static void DeleteCategory(SqlConnection connection)
{
    var deleteQuery = "DELETE [Category] WHERE [Id]=@id";
    var rows = connection.Execute(deleteQuery, new
    {
        id = new Guid("ea8059a2-e679-4e74-99b5-e4f0b310fe6f"),
    });

    Console.WriteLine($"{rows} registros excluídos");
}

static void CreateManyCategory(SqlConnection connection)
{
    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon AWS";
    category.Url = "amazon";
    category.Description = "Categoria destinada a serviços do AWS";
    category.Order = 8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    var category2 = new Category();
    category2.Id = Guid.NewGuid();
    category2.Title = "Categoria Nova";
    category2.Url = "categoria-nova";
    category2.Description = "Categoria nova";
    category2.Order = 9;
    category2.Summary = "Categoria";
    category2.Featured = true;

    var insertSql = @"INSERT INTO 
                    [Category] 
                VALUES(
                    @Id, 
                    @Title, 
                    @Url, 
                    @Summary, 
                    @Order, 
                    @Description, 
                    @Featured)";

    var rows = connection.Execute(insertSql, new[]{
                new
                {
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featured
                },
                new
                {
                    category2.Id,
                    category2.Title,
                    category2.Url,
                    category2.Summary,
                    category2.Order,
                    category2.Description,
                    category2.Featured
                }
            });
    Console.WriteLine($"{rows} linhas inseridas");
}

static void ExecuteProcedure(SqlConnection connection)
{
    var procedure = "[spDeleteStudent]";
    var pars = new { StudentId = "6bd552ea-7187-4bae-abb6-54e8f8b9f530" };
    var affectedRows = connection.Execute(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

    Console.WriteLine($"{affectedRows} linhas afetadas");
}

static void ExecuteReadProcedure(SqlConnection connection)
{
    var procedure = "[spGetCoursesByCategory]";
    var pars = new { CategoryId = "09ce0b7b-cfca-497b-92c0-3290ad9d5142" };
    var courses = connection.Query(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

    foreach (var item in courses)
    {
        Console.WriteLine(item.Title);
    }
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