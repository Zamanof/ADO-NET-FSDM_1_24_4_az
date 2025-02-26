using Microsoft.EntityFrameworkCore;

namespace ADO_NET_03._Database_First;

internal class LibraryContext:DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Lib> Libs { get; set; }

    public LibraryContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=True;Trust Server Certificate=True;");
    }
}
