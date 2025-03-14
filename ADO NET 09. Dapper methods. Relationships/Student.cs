namespace ADO_NET_09._Dapper_methods._Relationships;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int IdGroup { get; set; }

    public int Term { get; set; }

    public virtual Group IdGroupNavigation { get; set; } = null!;

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {IdGroupNavigation.Name}";
    }
}
