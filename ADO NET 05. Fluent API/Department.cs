namespace ADO_NET_05._Fluent_API;

internal class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public List<Teacher> Teachers { get; set; } = [];
}
