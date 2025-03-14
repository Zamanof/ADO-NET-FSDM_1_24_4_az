namespace ADO_NET_09._Dapper_methods._Relationships;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdFaculty { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public override string ToString()
    {
        return Name;
    }
}
