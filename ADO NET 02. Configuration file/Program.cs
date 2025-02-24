// Configuration file

using ADO_NET_02._Configuration_file;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

// connection string in file - not secure
//string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database = Library; 
//                            Integrated Security=True;Trust Server Certificate=True;";


// connection string in config file
//string connectionString = ConfigurationManager
//                    .ConnectionStrings["MyConnectionString"]
//                    .ConnectionString;

// connection string in JSON file
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

string connectionString = config.GetConnectionString("MyJsonCS")!; 


List<Author> authorList = new List<Author>();
using SqlConnection connection = new(connectionString);
connection.Open();
SqlCommand command = new("SELECT * FROM Authors", connection);
SqlDataReader reader = command.ExecuteReader();
while (reader.Read())
{
    authorList.Add(new Author
    {
        Id = (int)reader["Id"],
        FirstName = reader["FirstName"].ToString()!,
        LastName = reader["LastName"].ToString()!
    });
}

authorList.ForEach(Console.WriteLine);
