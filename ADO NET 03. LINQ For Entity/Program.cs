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
//    .Where(b=> EF.Functions.Like(b.Name, "%[0-9]%[0-9]%[0-9]%"))
//    .ToList()
//    .ForEach(b=> Console.WriteLine(b.Name));
#endregion

