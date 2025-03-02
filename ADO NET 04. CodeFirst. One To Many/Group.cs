namespace ADO_NET_04._CodeFirst._One_To_Many;

internal class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
