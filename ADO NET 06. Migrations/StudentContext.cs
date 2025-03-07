
using Microsoft.EntityFrameworkCore;

namespace ADO_NET_06._Migrations;

internal class StudentContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public StudentContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();cls
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
             .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Migration;Integrated Security=True;Trust Server Certificate=True;");
    }
}
