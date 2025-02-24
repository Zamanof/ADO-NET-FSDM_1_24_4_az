using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

string connectionString = config.GetConnectionString("MyJsonCS")!;

#region SQL Injection
//string id = Console.ReadLine()!;
//using (SqlConnection connection = new(connectionString))
//{
//    connection.Open();
//    SqlCommand command = new(@$"SELECT *
//                               FROM Authors
//                               WHERE Id={id}", connection);
//    SqlDataReader reader = command.ExecuteReader();
//    do
//    {
//        while (reader.Read())
//        {
//            for (int i = 0; i < reader.FieldCount; i++)
//            {
//                Console.Write($"{reader[i]}     \t\t");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine("\t\t");

//    } while (reader.NextResult());
//}
#endregion

#region parametrized query
using (SqlConnection connection = new(connectionString))
{
    connection.Open();
    string id = Console.ReadLine()!;
    string firstName = Console.ReadLine()!;
    SqlParameter parameter = new();
    //parameter.ParameterName = "@param1";
    //parameter.SqlDbType = System.Data.SqlDbType.Int;
    //parameter.Value = id;

    SqlCommand command = new(@"SELECT *
                               FROM Authors
                               WHERE Id > @id 
                               AND FirstName NOT LIKE @firstName", connection);
    //command.Parameters.Add(parameter);
    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
    command.Parameters.Add("@firstName", System.Data.SqlDbType.NVarChar).Value = firstName;
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

#endregion
