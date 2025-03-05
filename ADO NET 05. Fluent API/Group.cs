using System.ComponentModel.DataAnnotations;

namespace ADO_NET_05._Fluent_API;

internal class Group
{
    public int Id { get; set; }
    public string? GroupName { get; set; }
    public int GroupRating {  get; set; }
    public int CourseYear { get; set; } = 1;
    public List<Student> Students { get; set; } = [];
}
