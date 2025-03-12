namespace ADO_NET_08._Dapper;

internal interface IAuthorRepository
{
    Author AddAuthor(Author author);
    void AddAuthors(IEnumerable<Author> authors);
    void RemoveAuthor(int id);
    void RemoveAuthors(int[] authorIds);
    IEnumerable<Author> GetAllAuthors();
    Author GetAuthorById(string id);
}
