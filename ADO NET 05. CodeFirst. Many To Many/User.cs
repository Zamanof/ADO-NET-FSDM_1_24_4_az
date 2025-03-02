namespace ADO_NET_05._CodeFirst._Many_To_Many;

internal class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public List<SocialNetwork> SocialNetworks { get; set; } = [];
    public override string ToString()
    {
        return $"{Login} -> {FirstName} {LastName}";
    }

}
