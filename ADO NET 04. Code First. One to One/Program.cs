// Code First. Relationship -> One to One
using ADO_NET_04._Code_First._One_to_One;
using Microsoft.EntityFrameworkCore;

using StudentContext db = new();

//Student student = new Student()
//{
//    FirstName = "John",
//    LastName = "Doe",
//    BirthDay = new DateTime(10, 10, 10)
//};
//StudentCard studentCard = new StudentCard()
//{
//    StartDate = new DateTime(2025, 2, 28),
//    EndDate = new DateTime(2029, 2, 28),
//    Student = student
//};

//db.StudentCards.Add(studentCard);
//db.SaveChanges();

var studentCard = db.StudentCards.Include(sc=> sc.Student).First();
Console.WriteLine(studentCard);
Console.WriteLine(studentCard.Student);

