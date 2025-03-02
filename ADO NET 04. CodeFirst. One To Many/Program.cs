// See https://aka.ms/new-console-template for more information
using ADO_NET_04._CodeFirst._One_To_Many;
using Microsoft.EntityFrameworkCore;

//using (var db = new GroupContext())
//{
//    List<Student> students = new List<Student>
//        {
//            new Student { FirstName = "Clark", LastName = "Kent", BirthDay = new DateTime(1938, 6, 1) },
//            new Student { FirstName = "Bruce", LastName = "Wayne", BirthDay = new DateTime(1939, 5, 27) },
//            new Student { FirstName = "Diana", LastName = "Prince", BirthDay = new DateTime(1941, 10, 21) },
//            new Student { FirstName = "Barry", LastName = "Allen", BirthDay = new DateTime(1956, 10, 23) },
//            new Student { FirstName = "Hal", LastName = "Jordan", BirthDay = new DateTime(1959, 3, 20) },
//            new Student { FirstName = "Arthur", LastName = "Curry", BirthDay = new DateTime(1941, 11, 1) },
//            new Student { FirstName = "Victor", LastName = "Stone", BirthDay = new DateTime(1980, 4, 29) },
//            new Student { FirstName = "Oliver", LastName = "Queen", BirthDay = new DateTime(1941, 11, 20) },
//            new Student { FirstName = "John", LastName = "Stewart", BirthDay = new DateTime(1971, 12, 1) },
//            new Student { FirstName = "Billy", LastName = "Batson", BirthDay = new DateTime(1940, 2, 17) },
//            new Student { FirstName = "Kara", LastName = "Zor-El", BirthDay = new DateTime(1959, 5, 18) },
//            new Student { FirstName = "J'onn", LastName = "J'onzz", BirthDay = new DateTime(1955, 11, 28) },
//            new Student { FirstName = "Selina", LastName = "Kyle", BirthDay = new DateTime(1940, 4, 7) },
//            new Student { FirstName = "Dick", LastName = "Grayson", BirthDay = new DateTime(1940, 6, 6) },
//            new Student { FirstName = "Jason", LastName = "Todd", BirthDay = new DateTime(1983, 8, 16) },
//            new Student { FirstName = "Tim", LastName = "Drake", BirthDay = new DateTime(1989, 7, 19) },
//            new Student { FirstName = "Barbara", LastName = "Gordon", BirthDay = new DateTime(1967, 1, 14) },
//            new Student { FirstName = "Stephanie", LastName = "Brown", BirthDay = new DateTime(1992, 8, 3) },
//            new Student { FirstName = "Damian", LastName = "Wayne", BirthDay = new DateTime(2006, 9, 3) },
//            new Student { FirstName = "Zatanna", LastName = "Zatara", BirthDay = new DateTime(1964, 5, 20) }
//        };

//    Group group = new Group()
//    {
//        Name = "DC students",
//        Students = students
//    };

//    db.Groups.Add(group);

//    db.Groups.Add(new Group()
//    {
//        Name = "FSDM_1_24_4_az",
//        Students = new List<Student>() { new Student { FirstName = "Narmin", LastName = "Alishova", BirthDay = new DateTime(2000, 1, 1) },
//            new Student() { FirstName = "Ilqar", LastName = "Aliyev", BirthDay = new DateTime(2000, 1, 2) },
//            new Student() { FirstName = "Ekram", LastName = "Huseyinli", BirthDay = new DateTime(2000, 1, 3) },
//            new Student() { FirstName = "Tunay", LastName = "Huseynli", BirthDay = new DateTime(2000, 1, 4) },
//            new Student() { FirstName = "Nihad", LastName = "Memmedli", BirthDay = new DateTime(2000, 1, 5) },
//            new Student() { FirstName = "Bahruz", LastName = "Nuriyev", BirthDay = new DateTime(2000, 1, 6) },
//            new Student() { FirstName = "Vaqif", LastName = "Rasulzade", BirthDay = new DateTime(2000, 1, 7) },
//            new Student() { FirstName = "Ibrahim", LastName = "Rustamov", BirthDay = new DateTime(2000, 1, 8) },
//            new Student() { FirstName = "Ibrahim", LastName = "Sefereliyev", BirthDay = new DateTime(2000, 1, 9) },
//            new Student() { FirstName = "Murad", LastName = "Veliyev", BirthDay = new DateTime(2000, 1, 10) }
//        }
//    });

//    db.Groups.Add(new Group()
//    {
//        Name = "Teenage Mutant Ninja Turtles",
//        Students = [
//            new Student(){FirstName ="Leonardo", LastName = "Splinteroqlu"},
//            new Student(){FirstName ="Michelangelo", LastName = "Splinteroqlu"},
//            new Student(){FirstName ="Raphael", LastName = "Splinteroqlu"},
//            new Student(){FirstName ="Donatello", LastName = "Splinteroqlu"}
//            ]
//    });
//    db.SaveChanges();
//}


using var db = new GroupContext();
var groups = db.Groups.Include(g => g.Students).ToList();

foreach (var group in groups)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"\t{student}");
    }
}