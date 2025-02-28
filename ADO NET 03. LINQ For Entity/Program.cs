// LINQ For Entities

using ADO_NET_03._LINQ_For_Entity;
using Microsoft.EntityFrameworkCore;

using LibraryContext db = new();

//var authors = (
//    from author in db.Authors
//    where author.Id > 3
//    select author
//    ).ToList();

//authors.ForEach(Console.WriteLine);

#region Where
//db.Authors.Where(a => a.Id > 3 && a.Id < 7)
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors.Where(a => a.FirstName == "Mark")
//    .ToList()
//    .ForEach(Console.WriteLine);

#endregion

#region EF.Functions.Like()

//db.Authors.Where(a => a.FirstName.StartsWith("M"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.FirstName, "M%"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.FirstName, "_a%"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.FirstName, "[^M]%"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.FirstName, "[C-M]%"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Books
//    .Where(b => EF.Functions.Like(b.Name, "%[0-9]%[0-9]%[0-9]%"))
//    .ToList()
//    .ForEach(b => Console.WriteLine(b.Name));
#endregion

#region First, FirstOrDefault, Single, SingleOrDefault, Find
//var author = db.Authors.FirstOrDefault(a=> a.FirstName == "Olega");
//if (author is not null) Console.WriteLine(author);
//else Console.WriteLine("Author not found");

//var author1 = db.Authors.SingleOrDefault(a => a.FirstName == "Olga");
//if (author1 is not null) Console.WriteLine(author1);
//else Console.WriteLine("Author not found");

//var author2 = db.Authors.Find(51);
//if (author2 is not null) Console.WriteLine(author2);
//else Console.WriteLine("Author not found");
#endregion

#region All, Any

//Console.WriteLine(db.Authors.All(a=> a.FirstName.Length > 5));
//Console.WriteLine(db.Authors.Any(a=> a.FirstName == "Olga"));

#endregion

#region Select
//var authors = db.Authors.Select(a => new
//{
//    Id = a.Id,
//    FullName = $"{a.FirstName} {a.LastName}",
//    Books = a.Books
//});

//foreach (var author in authors)
//{
//    Console.WriteLine($"{author.Id}. {author.FullName}");
//    foreach (var book in author.Books)
//    {
//        Console.WriteLine($"\t{book}");
//    }
//}
#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending 
//var authors = db.Authors
//        .OrderBy(a => a.FirstName)
//        .ThenByDescending(a => a.LastName)
//        .ToList();

///*
//    SELECT Id, FirstName, LastName
//    FROM Authors
//    ORDER BY FirstName, LastName DESC

// */

//authors.ForEach(Console.WriteLine);
#endregion

#region Join
//var books = db.Books.Join(db.Authors, b => b.IdAuthor, a => a.Id,
//    (b, a) => new
//    {
//        Name = b.Name,
//        Author = $"{a.FirstName} {a.LastName}"
//    }).ToList();

///*
//    SELECT B.[Name], A.FirstName + ' ' + A.LastName AS Author
//    FROM Books AS B
//    JOIN Authors AS A ON B.Id_Author = A.Id 
// */

//books.ForEach(b => Console.WriteLine($"Book name: {b.Name}\nAuthor:    {b.Author}\n"));

#endregion

#region Take, TakeWhile, Skip, SkipWhile
//var authors = db.Authors
//                    .OrderBy(a=> a.FirstName)
//                    .Skip(4)
//                    .Take(3)
//                    .ToList();

///*
//    SELECT *
//    FROM Authors
//    ORDER BY FirstName
//    OFFSET (4) ROWS
//    FETCH NEXT (3) ROWS ONLY 
//*/

//authors.ForEach(Console.WriteLine);


#endregion

/* 
    https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/supported-and-unsupported-linq-methods-linq-to-entities
    LINQ to Entities:
    
        All
        Any
        Average
        Contains
        Count
        First
        FirstOrDefault
        Single
        SingleOrDefault
        Select
        Where
        OrderBy
        OrderByDescending
        ThenBy
        ThenByDescending
        Join
        LeftJoin
        GroupBy
        Except
        Union
        Intersect
        Sum
        Max
        Min
        Take
        TakeWhile
        Skip
        SkipWhile
        ToList
*/

