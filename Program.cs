using Microsoft.Extensions.Configuration;
using Microsoft.Data.Sqlite;
using Dapper;

class Program()
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        string? connectionString = config.GetConnectionString("Flashcards");

        Console.WriteLine(connectionString);
        Console.ReadLine();
    }
}