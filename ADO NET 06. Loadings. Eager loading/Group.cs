namespace ADO_NET_06._Loadings._Eager_loading;

internal class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    public List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return GroupName;
    }
}
