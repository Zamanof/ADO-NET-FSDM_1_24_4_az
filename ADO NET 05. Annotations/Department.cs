namespace ADO_NET_05._Annotations;

internal class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public List<Teacher> Teachers { get; set; } = [];
}
