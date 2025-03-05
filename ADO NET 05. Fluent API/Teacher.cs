using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADO_NET_05._Fluent_API;

internal class Teacher
{
    public int TeacherId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }

    public DateTime BirthDay { get; set; }
    public float Salary { get; set; }
    public float Bonus { get; set; }
}
