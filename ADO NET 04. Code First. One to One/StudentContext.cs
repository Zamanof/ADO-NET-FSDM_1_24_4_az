using Microsoft.EntityFrameworkCore;

namespace ADO_NET_04._Code_First._One_to_One;

internal class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentCard> StudentCards { get; set; }

    public StudentContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OneToOne;Integrated Security=True;Trust Server Certificate=True;");
    }
}
