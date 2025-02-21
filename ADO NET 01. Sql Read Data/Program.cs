using Microsoft.Data.SqlClient;

string connectionString = @"Server=MOGUDA_PC; Integrated Security = SSPI; 
                            Database = AdoTest; Trust Server Certificate=True;";

SqlDataReader reader = null!;
SqlCommand cmd = null!;

#region Read Data
//using SqlConnection connection = new SqlConnection(connectionString);
//cmd = new SqlCommand(@"SELECT * FROM Authors", connection);
//connection.Open();
//reader = cmd.ExecuteReader();

//while (reader.Read())
//{
//    Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//}


//using SqlConnection connection = new SqlConnection(connectionString);
//cmd = new SqlCommand(@"SELECT * FROM Authors", connection);
//connection.Open();
//reader = cmd.ExecuteReader();

//while (reader.Read())
//{
//    Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//}


connectionString = @"Server=(localdb)\MSSQLLocalDB; Database = Library; 
Integrated Security=True;Trust Server Certificate=True;";

//using SqlConnection connection = new SqlConnection(connectionString);
//cmd = new(@"SELECT * FROM Authors", connection);
//connection.Open();
//reader = cmd.ExecuteReader();
//while (reader.Read())
//{
//    Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//}


using SqlConnection connection = new SqlConnection(connectionString);
cmd = new(@"SELECT * FROM Authors", connection);
connection.Open();
reader = cmd.ExecuteReader();
bool line = true;

//Console.WriteLine(reader.FieldCount);
while (reader.Read())
{
    if (line)
    {
        for (int i = 0; i < reader.FieldCount; i++)
        {
            Console.Write($"{reader.GetName(i)}              ");
        }
        line = false;
    }
    Console.WriteLine();
    for (int i = 0; i < reader.FieldCount; i++)
    {
        Console.Write($"{reader[i]}              ");
    }
}

#endregion

