using Welcome.Model;
using Welcome.ViewModel;
using Welcome.View;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new();
            user.Names = "joe";
            user.Password = "Most seured password ever";
            user.Role = Welcom.Others.UserRolesEnums.PROFESSOR;
            UserViewModel userViewModel = new UserViewModel(user);
            UserView userView = new UserView(userViewModel);
            userView.Display();
            Console.ReadKey();

        }
    }
}