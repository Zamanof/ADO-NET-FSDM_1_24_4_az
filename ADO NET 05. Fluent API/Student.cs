namespace ADO_NET_05._Fluent_API;

internal class Student
{
    public int Id { get; set; }    
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int GroupId {  get; set; } // ForeignKey
    public virtual Group Group { get; set; } // Navigation Property
}
