using Microsoft.EntityFrameworkCore;

namespace ADO_NET_05._CodeFirst._Many_To_Many;

internal class SocialContext: DbContext
{
    public DbSet<SocialNetwork> SocialNetworks { get; set; }
    public DbSet<User> Users { get; set; }

    public SocialContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=True;Trust Server Certificate=True;");

    }
}
