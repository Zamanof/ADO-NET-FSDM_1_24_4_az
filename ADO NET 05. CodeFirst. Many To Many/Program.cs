using ADO_NET_05._CodeFirst._Many_To_Many;
using Microsoft.EntityFrameworkCore;

using SocialContext db = new();

SocialNetwork facebook = new SocialNetwork() { Name = "Facebook" };
SocialNetwork instagram = new SocialNetwork() { Name = "Instagram" };
SocialNetwork threads = new SocialNetwork() { Name = "Threads" };

User user = new()
{
    FirstName = "Nadir",
    LastName = "Zamanov",
    Login = "zamanov@itstep.org",
    Password = "qwerty123456789"
};

facebook.Users.Add(user);
instagram.Users.Add(user);
threads.Users.Add(user);

db.SocialNetworks.AddRange(facebook, instagram, threads);
db.SaveChanges();

var _instagram = db.SocialNetworks.Where(cn => cn.Name == "Instagram").Include(cn => cn.Users).First();
_instagram.Users.Add(new User
{
    FirstName = "John",
    LastName = "Doe",
    Login = "Lorem",
    Password = "Ipsum"
});
db.SaveChanges();

//var networks = db.SocialNetworks.Include(sn=> sn.Users).ToList();

//foreach (var network in networks)
//{
//    Console.WriteLine(network);
//    foreach (var user in network.Users)
//    {
//        Console.WriteLine($"\t{user}");
//    }
//}