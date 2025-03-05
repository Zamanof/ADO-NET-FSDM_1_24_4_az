using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADO_NET_05._Annotations;

internal class Teacher
{
    [Key] // property-ni PRIMARY KEY elan edir
    [Column("Id")] 
    // TeacherId(Entity) <-> Id(DB)
    public  int TeacherId { get; set; }
    [Required]
    [MaxLength(30)]
    public string? FirstName { get; set; }
    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }
    [Required]
    [Column(TypeName ="varchar(50)")] // DB-de hansi datatype olacaqini teyin edir
    public string? Email {  get; set; }

    public DateTime BirthDay { get; set; }
    public float Salary {  get; set; }
    public float Bonus { get; set; }
}
