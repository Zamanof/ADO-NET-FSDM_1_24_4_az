using Microsoft.EntityFrameworkCore;

namespace ADO_NET_03._Entity_intro;

internal class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }

    public StudentContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Students;Integrated Security=True;Trust Server Certificate=True;");
    }
}
