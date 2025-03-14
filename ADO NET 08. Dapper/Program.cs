// Dapper ORM
using ADO_NET_08._Dapper;
using Microsoft.Data.SqlClient;

var cs = @"Database=Author; Server=(localdb)\MSSQLLocalDB; Integrated Security=SSPI; Trust Server Certificate=True";

IAuthorRepository repo = new AuthorRepository(new SqlConnection(), cs);

#region Add data
//var author = repo.AddAuthor(new Author
//{
//    FirstName = "Ali",
//    LastName = "Aliyev"
//});
//Console.WriteLine(author);
#endregion

#region read datas
//var authors = repo.GetAllAuthors().ToList();

//authors.ForEach(Console.WriteLine);
#endregion

#region Remove Data
//repo.RemoveAuthor(1);
#endregion

Console.WriteLine(repo.GetAuthorById("2; DROP TABLE Author;"));