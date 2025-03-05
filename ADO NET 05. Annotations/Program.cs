using ADO_NET_05._Annotations;
// Entity Model - Annotation


using SchoolContext db = new();

Student student = new()
{
    FirstName = "Adam",
    LastName = "Adamov"
};
db.Students.Add(student);
Group group = new()
{
    GroupName = "FSDM_1_24_4_az",
    GroupRaiting = 10,
    CourseYear = 2,
    Students = [student]
};

db.Groups.Add(group);

Faculty faculty = new()
{
    FacultyName = ".NET Programming"
};

db.Faculties.Add(faculty);

Department department = new()
{
    DepartmentName = "Programming"
};

db.Departments.Add(department);

Teacher teacher1 = new()
{
    FirstName = "Nadir",
    LastName = "Zamanov",
    BirthDay = new DateTime(1980, 10, 7),
    Salary = 1000000,
    Bonus = 200000,
    Email = "Zamanov@itstep.org"
};

Teacher teacher2 = new()
{
    FirstName = "Ismayil",
    LastName = "Seyidmemmedli",
    BirthDay = new DateTime(1998, 10, 7),
    Salary = 5000000,
    Bonus = 500000,
    Email = "Seyidmemmedli@itstep.org"
};
db.Teachers.AddRange(teacher1, teacher2);

db.SaveChanges();
