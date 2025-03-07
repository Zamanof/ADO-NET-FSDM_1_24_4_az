
using ADO_NET_06._Migrations;

using (var db = new StudentContext())
{
    Student student = new()
    {
        FirstName = "Salam",
        LastName = "Salamzade",
        Age = 19,
        Email = "salamzade@gmail.com"
    };
    db.Students.AddRange(
        student,
        new()
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 60,
            Email = "JohnDoe@doe.az"
        });
    db.SaveChanges();

}
