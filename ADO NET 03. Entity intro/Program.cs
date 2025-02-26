using ADO_NET_03._Entity_intro;

// Entity Framework Core

// Database First
// Code First
// Model First

#region Add Data
//using (StudentContext db = new())
//{
//    Student student1 = new() {
//        FirstName = "John",
//        LastName = "Wick",
//        BirthDate = new DateTime(1964, 9, 12)
//        };
//    db.Students.Add(student1);
//    db.SaveChanges();
//}
#endregion

#region Read Data
//using (var db = new StudentContext())
//{
//    var student = db.Students.FirstOrDefault(s=> s.Id == 1);
//    if (student is not null) Console.WriteLine(student);
//    else Console.WriteLine("Student Not Found");
//}
#endregion

#region Add Datas
//using var db = new StudentContext();

//List<Student> students = new List<Student>
//        {
//            new Student { FirstName = "Elvin", LastName = "Məmmədov", BirthDate = new DateTime(2005, 3, 15) },
//            new Student { FirstName = "Aysel", LastName = "Hüseynova", BirthDate = new DateTime(2006, 7, 22) },
//            new Student { FirstName = "Nihad", LastName = "Quliyev", BirthDate = new DateTime(2004, 5, 10) },
//            new Student { FirstName = "Ləman", LastName = "Əliyeva", BirthDate = new DateTime(2007, 1, 30) },
//            new Student { FirstName = "Rəşad", LastName = "Hacıyev", BirthDate = new DateTime(2005, 9, 5) },
//            new Student { FirstName = "Fidan", LastName = "Əkbərova", BirthDate = new DateTime(2006, 11, 12) },
//            new Student { FirstName = "Orxan", LastName = "Qasımov", BirthDate = new DateTime(2005, 4, 18) },
//            new Student { FirstName = "Günay", LastName = "Məmmədova", BirthDate = new DateTime(2007, 6, 25) },
//            new Student { FirstName = "Tural", LastName = "İsmayılov", BirthDate = new DateTime(2004, 2, 8) },
//            new Student { FirstName = "Zeynəb", LastName = "Rzayeva", BirthDate = new DateTime(2006, 12, 14) },
//            new Student { FirstName = "Murad", LastName = "Qurbanov", BirthDate = new DateTime(2005, 8, 19) },
//            new Student { FirstName = "Nərgiz", LastName = "Quliyeva", BirthDate = new DateTime(2006, 10, 3) },
//            new Student { FirstName = "Emin", LastName = "Babayev", BirthDate = new DateTime(2004, 7, 21) },
//            new Student { FirstName = "Şəbnəm", LastName = "Abdullayeva", BirthDate = new DateTime(2007, 5, 7) },
//            new Student { FirstName = "Ramin", LastName = "Səfərov", BirthDate = new DateTime(2005, 3, 29) },
//            new Student { FirstName = "Sevinc", LastName = "Əliyeva", BirthDate = new DateTime(2006, 9, 16) },
//            new Student { FirstName = "Cavid", LastName = "Məmmədov", BirthDate = new DateTime(2004, 1, 12) },
//            new Student { FirstName = "Ülviyyə", LastName = "Orucova", BirthDate = new DateTime(2007, 11, 28) },
//            new Student { FirstName = "Eldar", LastName = "Sadıqov", BirthDate = new DateTime(2005, 6, 4) },
//            new Student { FirstName = "Aytac", LastName = "Məmmədli", BirthDate = new DateTime(2006, 8, 30) },
//            new Student { FirstName = "Rövşən", LastName = "Qarayev", BirthDate = new DateTime(2004, 4, 17) },
//            new Student { FirstName = "Samir", LastName = "Hüseynov", BirthDate = new DateTime(2007, 2, 9) },
//            new Student { FirstName = "Kamil", LastName = "Bağırov", BirthDate = new DateTime(2005, 12, 6) },
//            new Student { FirstName = "Səidə", LastName = "Vəliyeva", BirthDate = new DateTime(2006, 1, 25) },
//            new Student { FirstName = "Ümid", LastName = "Aslanov", BirthDate = new DateTime(2004, 10, 11) },
//            new Student { FirstName = "Pərviz", LastName = "Xəlilov", BirthDate = new DateTime(2007, 3, 20) },
//            new Student { FirstName = "Aylin", LastName = "Nəsirova", BirthDate = new DateTime(2005, 5, 14) },
//            new Student { FirstName = "Ceyhun", LastName = "Əliyev", BirthDate = new DateTime(2006, 7, 8) },
//            new Student { FirstName = "Nəsib", LastName = "Əsədov", BirthDate = new DateTime(2004, 9, 27) },
//            new Student { FirstName = "Leyla", LastName = "Mustafayeva", BirthDate = new DateTime(2007, 12, 31) }
//        };

//db.Students.AddRange(students);
//db.SaveChanges();
#endregion

#region Read Datas
//using var db = new StudentContext();
//var students = db.Students.ToList();

//students.ForEach(Console.WriteLine);
#endregion

#region Delete data
//using var db = new StudentContext();

//db.Remove(db.Students.First());
//db.SaveChanges();

//var deleteStudents = db.Students.Where(s => s.Id < 6);
//db.Students.RemoveRange(deleteStudents);
//db.SaveChanges();


//var students = db.Students.ToList();

//students.ForEach(Console.WriteLine);

#endregion

#region Update data
//using var db = new StudentContext();
//var student = db.Students.FirstOrDefault(x => x.Id == 3);
//if (student is not null)
//{
//    student.FirstName = "ALi";
//    db.Update(student);
//}
//db.SaveChanges();

#endregion

//using var db = new StudentContext();

//db.Database.EnsureDeleted();

