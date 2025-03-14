namespace ADO_NET_09._Dapper_methods._Relationships;

internal class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int YearPress { get; set; }

    public int IdThemes { get; set; }

    public int IdCategory { get; set; }

    public int IdAuthor { get; set; }

    public int IdPress { get; set; }

    public string? Comment { get; set; }

    public int Quantity { get; set; }

    public virtual Author IdAuthorNavigation { get; set; } = null!;

    public override string ToString()
    {
        return $"{Id}. {Name} -> {Pages} pages";
    }
}
