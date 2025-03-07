namespace ADO_NET_06._Loadings._Eager_loading;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public int GroupId { get; set; }
    public virtual Group Group { get; set; } // Navigation Property
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
