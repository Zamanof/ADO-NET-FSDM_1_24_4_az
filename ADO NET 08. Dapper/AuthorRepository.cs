using Dapper;
using System.Data;

namespace ADO_NET_08._Dapper;
internal class AuthorRepository: IAuthorRepository
{
    private IDbConnection _db;
    public AuthorRepository(IDbConnection db, string cs)
    {
        _db = db;
        _db.ConnectionString = cs;
    }

    public Author AddAuthor(Author author)
    {
        var sql =
@"INSERT INTO Author(FirstName, LastName)
VALUES(@FirstName, @LastName)
SELECT CAST(SCOPE_IDENTITY() AS int)";

        var id = _db.Query<int>(sql, new
        {
            @FirstName = author.FirstName,
            @LastName = author.LastName
        }).FirstOrDefault();
        author.Id = id;
        return author;
    }

    public void AddAuthors(IEnumerable<Author> authors)
    {
        foreach (var author in authors)
        {
            AddAuthor(author);
        }
    }

    public IEnumerable<Author> GetAllAuthors()
    {
        var sql = "SELECT * FROM Author";
        return _db.Query<Author>(sql);
    }

    public Author GetAuthorById(string id)
    {
        var sql = $"SELECT * FROM Author WHERE Id = @id";
        return _db.QueryFirstOrDefault<Author>(sql, new {@id = id})!;
    }

    public void RemoveAuthor(int id)
    {
        var sql = "DELETE FROM Author WHERE Id=@id";
        _db.Execute(sql, new {@id=id});
    }

    public void RemoveAuthors(int[] authorIds)
    {
        foreach (var id in authorIds)
        {
            RemoveAuthor(id);
        }
    }
}
