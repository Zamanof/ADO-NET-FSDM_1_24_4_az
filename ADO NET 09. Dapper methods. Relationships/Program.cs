using ADO_NET_09._Dapper_methods._Relationships;
using Dapper;
using Microsoft.Data.SqlClient;

SqlConnection db = new(@"Server=(localdb)\MSSQLLocalDB; Database=Library; Integrated Security=SSPI; Trust Server Certificate=True;");

#region ExecuteScalar
//var result = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Books");
//Console.WriteLine(result);
//Console.WriteLine(db.ExecuteScalar<float>("SELECT AVG(Pages) FROM Books"));
#endregion

#region Single Row Query - QueryFirst, QuerySingle, QueryFirstOrDefault, QuerySingleOrDefault
//var book = db.QueryFirstOrDefault<Book>(@"
//SELECT * 
//FROM Books 
//WHERE Name LIKE @Name", new { @Name = "%Visual%" });
///*
//SELECT TOP(1) * 
//FROM Books 
//WHERE Name LIKE '%Visual%'
// */

//if (book is not null) Console.WriteLine(book);
//else Console.WriteLine("Book not found");

//var book1 = db.QuerySingleOrDefault<Book>(@"
//SELECT * 
//FROM Books 
//WHERE Name LIKE @Name", new { @Name = "Visual Basic 6.0 for Application" });
//Console.WriteLine(book1);
#endregion

#region Query
//var books = db.Query<Book>("SELECT * FROM Books").ToList();
//books.ForEach(Console.WriteLine);
#endregion

#region QueryMultiply, Read, ReadFirstOrDefault, ReadSingle, ReadSingleOrDefault
//var sql = @"SELECT * FROM Authors WHERE FirstName = @FirstName;
//SELECT * FROM Books WHERE Id > @Id;";

//var results = db.QueryMultiple(sql, new {@FirstName = "Mark", @Id = 3});

//var authors = results.Read<Author>().ToList();
//var books = results.Read<Book>().ToList();

//authors.ForEach(Console.WriteLine);

//Console.WriteLine();

//books.ForEach(Console.WriteLine);

//Console.WriteLine(results.ReadFirstOrDefault<Author>());
//Console.WriteLine(results.ReadFirstOrDefault<Book>());


#endregion

#region Specific Columns
//var sql = "SELECT Id, FirstName FROM Authors";
//var authors = db.Query<Author>(sql).ToList();
//authors.ForEach(Console.WriteLine);
#endregion

#region One To Many
//var sql = @"
//SELECT *
//FROM Students AS S
//JOIN Groups AS G
//ON S.Id_Group = G.Id";

//var students = db.Query<Student, Group, Student>(sql,
//    (s, g) =>
//    {
//        s.IdGroupNavigation = g;
//        return s;
//    }).ToList();




//students.ForEach(Console.WriteLine);
//var groupDict = new Dictionary<int, Group>();
//var groups = db.Query<Student, Group, Group>(sql,
//    (s, g) =>
//    {
//        if (!groupDict.TryGetValue(g.Id, out var existingGroup))
//        {
//            existingGroup = g;
//            existingGroup.Students = new List<Student>();
//            groupDict.Add(g.Id, existingGroup);
//        }

//        existingGroup.Students.Add(s);
//        return existingGroup;
//    }).Distinct().ToList();

//foreach (var group in groups)
//{
//    Console.WriteLine(group);
//    foreach (var student in group.Students.ToList())
//    {
//        Console.WriteLine($"    {student.FirstName} {student.LastName}");
//    };
//}

#endregion

#region ManyToMany
//SqlConnection db1 = new(@"Server=(localdb)\MSSQLLocalDB; Database=ManyToMany; Integrated Security=SSPI; Trust Server Certificate=True;");
//var sql = @"
//SELECT *
//FROM SocialNetworks AS SN
//JOIN SocialNetworkUser AS SNU
//ON SN.Id = SNU.SocialNetworksId
//JOIN Users AS U
//ON SNU.UsersId = U.Id";

//var results = db1.Query<SocialNetwork, User, SocialNetwork>(sql,
//    (sn, u)=>
//    {
//        sn.Users.Add(u);
//        return sn;
//    });

//foreach (var r in results)
//{
//    Console.WriteLine(r.Name);
//    foreach (var u in r.Users)
//    {
//        Console.WriteLine($"    {u}");
//    }
//}
#endregion