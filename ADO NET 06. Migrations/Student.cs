namespace ADO_NET_06._Migrations;
internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    public int Age { get; set; }
    public string Email {  get; set; }
    public bool? Gender { get; set; }
    public bool isActive { get; set; } = false;

}
