#region ADO
// ADO - ActiveX Data Object for .NET

// MSSQL Server, Oracle, OLE DB, ODBC

// ADO Classes for
// DbConnection (SqlConnection, ...)
// DbCommand
// DbDataReader
// DbDataAdapter
// ...

// ADO Datatype for DB
// DataTable
// DataSet
// ...

// Connected mode
// Disconnected
#endregion

#region ConnectionStrings
// Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
// Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
// Data Source = MOGUDA_PC; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate=True; Application Intent = ReadWrite; Multi Subnet Failover=False
#endregion

using Microsoft.Data.SqlClient;

SqlConnection sqlConnection = default!;
string connectionString = @"Server=MOGUDA_PC; Integrated Security = SSPI; Database = AdoTest; Trust Server Certificate=True;";

sqlConnection = new SqlConnection(connectionString);
string insertQuery = @"INSERT INTO Authors(FirstName, LastName)
                        VALUES('Joseph', 'Albahari')";

//SqlCommand command = new SqlCommand(insertQuery, sqlConnection);

SqlCommand command = new();
//command.Connection = sqlConnection;
//command.CommandText = insertQuery;

//try
//{
//    sqlConnection.Open();
//    command.ExecuteNonQuery();
//}
//finally
//{
//    if(sqlConnection != null) sqlConnection.Close();
//}

using (sqlConnection = new(connectionString))
{
    sqlConnection.Open();
    string FirstName = Console.ReadLine()!;
    string LastName = Console.ReadLine()!;
    insertQuery = @$"INSERT INTO Authors(FirstName, LastName)
                        VALUES('{FirstName}', '{LastName}')";
    command.Connection = sqlConnection;
    command.CommandText = insertQuery;
    command.ExecuteNonQuery();
}

