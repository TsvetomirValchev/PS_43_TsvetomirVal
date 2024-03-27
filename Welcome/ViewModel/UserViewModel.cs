using Welcom.Others;
using Welcome.Model;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }

        public string Name {
           
            get { return _user.Names; }
            set { _user.Names = value; }
   
        }

        public UserRolesEnums Role
        {

            get { return _user.Role; }
            set { _user.Role = value; }

        }

        public string Password
        {

            get { return _user.Password; }
            set { _user.Password = value; }

        }


    }
}
