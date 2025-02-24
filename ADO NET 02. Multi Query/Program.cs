using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

string connectionString = config.GetConnectionString("MyJsonCS")!;

using (SqlConnection connection = new(connectionString))
{
    connection.Open();
    SqlCommand command = new(@"SELECT *
                               FROM Authors;
                               SELECT Id, Pages, Name
                               FROM Books;", connection);
    SqlDataReader reader = command.ExecuteReader();
    do
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]}     \t\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\t\t");

    } while (reader.NextResult());
}
