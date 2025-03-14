namespace ADO_NET_09._Dapper_methods._Relationships;

internal class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual List<Book> Books { get; set; } = [];

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName}";
    }
}
