using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADO_NET_05._Annotations;

internal class Student
{
    public int Id { get; set; }
    
    [Required] // Bu column-un vacib olduqunu qeyd edir ve NOT NULL edecek
    [MaxLength(20)] // maksimal uzunluqumuzu elan edir
    public string? FirstName { get; set; }
    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }

    [ForeignKey("Group")]
    [Column("Id_Group")]
    public int GroupId {  get; set; } // ForeignKey

    public virtual Group Group { get; set; } // Navigation Property

}
