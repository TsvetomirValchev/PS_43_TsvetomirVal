using DataLayer.Database;
using DataLayer.Model;

using static Welcome.Others.UserRolesEnums;

using (var context = new DatabaseContext())
{
    context.Database.EnsureCreated();
    context.Add<DatabaseUser>(new DatabaseUser()
    {
        Name = "user",
        Password = "password",
        Expires = DateTime.Now,
        Role = STUDENT

    });

    context.SaveChanges();
    var users = context.Users.ToList();
    Console.ReadKey();
}
