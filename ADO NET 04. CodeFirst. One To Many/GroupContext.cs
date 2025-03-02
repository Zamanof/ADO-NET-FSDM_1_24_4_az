using Microsoft.EntityFrameworkCore;

namespace ADO_NET_04._CodeFirst._One_To_Many;

internal class GroupContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    public GroupContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OneToMany;Integrated Security=True;Trust Server Certificate=True;");

    }
}
