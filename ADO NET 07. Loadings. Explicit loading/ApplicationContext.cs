using Microsoft.EntityFrameworkCore;

namespace ADO_NET_07._Loadings._Explicit_loading;

internal class ApplicationContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
             .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ExplicitLoading;Integrated Security=True;Trust Server Certificate=True;");
    }
}
