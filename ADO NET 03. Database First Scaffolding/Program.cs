using ADO_NET_03._Database_First_Scaffolding;

using LibraryContext db = new LibraryContext();

var authors = db.Authors.ToList();

var libs = db.Libs.ToList();

authors.ForEach(Console.WriteLine);
Console.WriteLine();
libs.ForEach(Console.WriteLine);
