// Read relational datas

// + Eager loading
// - Explicit loading
// - Lazy loading


using ADO_NET_06._Loadings._Eager_loading;
using Microsoft.EntityFrameworkCore;

#region Add Data
// Add Data
//using (var db = new ApplicationContext())
//{
//List<Student> students = new List<Student>
//    {
//        new Student { FirstName = "Ali", LastName = "Hüseynov", Age = 20 },
//        new Student { FirstName = "Aysel", LastName = "Məmmədova", Age = 19 },
//        new Student { FirstName = "Elvin", LastName = "Quliyev", Age = 21 },
//        new Student { FirstName = "Günay", LastName = "Əliyeva", Age = 22 },
//        new Student { FirstName = "Fuad", LastName = "İsmayılov", Age = 23 },
//        new Student { FirstName = "Nigar", LastName = "Səfərova", Age = 20 },
//        new Student { FirstName = "Orxan", LastName = "Rəhimli", Age = 24 },
//        new Student { FirstName = "Leyla", LastName = "Zeynalova", Age = 18 },
//        new Student { FirstName = "Murad", LastName = "Həsənov", Age = 22 },
//        new Student { FirstName = "Samir", LastName = "Bağırov", Age = 21 },
//        new Student { FirstName = "Turan", LastName = "Sadıqov", Age = 19 },
//        new Student { FirstName = "Fidan", LastName = "Qasımova", Age = 20 },
//        new Student { FirstName = "Cavid", LastName = "Əhmədov", Age = 23 },
//        new Student { FirstName = "Səbinə", LastName = "Qurbanova", Age = 19 },
//        new Student { FirstName = "Taleh", LastName = "Mirzəyev", Age = 25 },
//        new Student { FirstName = "Sevinc", LastName = "Rüstəmova", Age = 22 },
//        new Student { FirstName = "Kamran", LastName = "Mustafayev", Age = 21 },
//        new Student { FirstName = "Elçin", LastName = "Hüseynov", Age = 20 },
//        new Student { FirstName = "Narmin", LastName = "Əliyeva", Age = 23 },
//        new Student { FirstName = "Ramin", LastName = "Sultanov", Age = 24 }
//    };

//List<Student> physicists = new List<Student>
//    {
//        new Student { FirstName = "Albert", LastName = "Einstein", Age = 76 },
//        new Student { FirstName = "Isaac", LastName = "Newton", Age = 84 },
//        new Student { FirstName = "Marie", LastName = "Curie", Age = 66 },
//        new Student { FirstName = "Richard", LastName = "Feynman", Age = 69 },
//        new Student { FirstName = "Niels", LastName = "Bohr", Age = 77 },
//        new Student { FirstName = "Stephen", LastName = "Hawking", Age = 76 },
//        new Student { FirstName = "Galileo", LastName = "Galilei", Age = 77 },
//        new Student { FirstName = "Max", LastName = "Planck", Age = 89 },
//        new Student { FirstName = "Erwin", LastName = "Schrödinger", Age = 73 },
//        new Student { FirstName = "Werner", LastName = "Heisenberg", Age = 74 }
//    };
//db.Groups.AddRange(
//    new Group() { GroupName = "FSDM_13_13_13_az", Students = students },
//    new Group() { GroupName = "Physicist", Students = physicists },
//    new Group()
//    {
//        GroupName = "DC Group",
//        Students = new List<Student>
//    {
//        new Student { FirstName = "Bruce", LastName = "Wayne", Age = 35 },
//        new Student { FirstName = "Clark", LastName = "Kent", Age = 33 },
//        new Student { FirstName = "Diana", LastName = "Prince", Age = 3000 },
//        new Student { FirstName = "Barry", LastName = "Allen", Age = 25 },
//        new Student { FirstName = "Hal", LastName = "Jordan", Age = 30 },
//        new Student { FirstName = "Arthur", LastName = "Curry", Age = 32 },
//        new Student { FirstName = "Victor", LastName = "Stone", Age = 22 },
//        new Student { FirstName = "Oliver", LastName = "Queen", Age = 34 },
//        new Student { FirstName = "John", LastName = "Constantine", Age = 40 },
//        new Student { FirstName = "Billy", LastName = "Batson", Age = 15 },
//        new Student { FirstName = "J'onn", LastName = "J'onzz", Age = 500 },
//        new Student { FirstName = "Kara", LastName = "Zor-El", Age = 27 },
//        new Student { FirstName = "Selina", LastName = "Kyle", Age = 29 }
//    }
//    });

//db.SaveChanges();
//var groups = db.Groups.ToList();

//foreach (var group in groups)
//{
//    Console.WriteLine(group);
//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"    {student}");
//    }
//}
//}
#endregion

#region Eager loading, Include(), ThenInclude() 

using (var db = new ApplicationContext())
{
    var groups = db.Groups.ToList();
    foreach (var group in groups)
    {
        Console.WriteLine(group);
        foreach (var student in group.Students)
        {
            Console.WriteLine($"    {student}");
        }
    }

    //var students = db.Students.Include(s=>s.Group).ToList();

    //foreach (var student in students)
    //{
    //    Console.WriteLine($"{student} - {student.Group}");
    //}
}

#endregion


