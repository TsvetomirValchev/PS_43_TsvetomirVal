using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public virtual int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRolesEnums Role { get; set; }
        public virtual DateTime Expires { get; set; }

    }
}
