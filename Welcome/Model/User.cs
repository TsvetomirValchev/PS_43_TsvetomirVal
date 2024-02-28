using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcom.Others;

namespace Welcome.Model
{
    internal class User
    {
        public string Names { get; set; }
        public string Password { get; set; }
        public UserRolesEnums Role { get; set; }

    }
}
