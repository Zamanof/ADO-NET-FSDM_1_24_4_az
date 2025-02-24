using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

string connectionString = config.GetConnectionString("MyJsonCS")!;

#region Create Procedure
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    connection.Open();
//    SqlCommand command = new(
//@"CREATE PROC getBookCount
//@AuthorId int, @BookCount int OUTPUT
//AS
//BEGIN
//    SELECT @BookCount = COUNT(*)
//    FROM Books AS B JOIN Authors AS A ON B.Id_Author = A.Id
//    WHERE A.Id = @AuthorId
//END
//", connection);
//    command.ExecuteNonQuery();

//}
#endregion

#region execute procedure
using (SqlConnection connection = new(connectionString))
{
    connection.Open();
    SqlCommand command = new("getBookCount", connection);
    command.CommandType = System.Data.CommandType.StoredProcedure;
    command.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int).Value = Console.ReadLine();
    SqlParameter output = new("@BookCount", System.Data.SqlDbType.Int);
    output.Direction = System.Data.ParameterDirection.Output;
    command.Parameters.Add(output);
    command.ExecuteNonQuery();
    Console.WriteLine(command.Parameters["@BookCount"].Value);
}
#endregion

