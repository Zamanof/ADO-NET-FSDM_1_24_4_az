using Microsoft.EntityFrameworkCore;

namespace ADO_NET_05._Annotations;

internal class SchoolContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

    public SchoolContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AcademyWithAnnotations;Integrated Security=True;Trust Server Certificate=True;")
            .UseValidationCheckConstraints();
    }
}
