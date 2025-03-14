namespace ADO_NET_09._Dapper_methods._Relationships;

internal class SocialNetwork
{
    public int Id {  get; set; }
    public string Name { get; set; }

    public List<User> Users { get; set; } = [];

    public override string ToString()
    {
        return Name;
    }
}
