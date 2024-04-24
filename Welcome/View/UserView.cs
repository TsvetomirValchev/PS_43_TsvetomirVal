using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {

            Console.WriteLine($"Welcome! \nUser: {_viewModel.Name} " +
                $"\nEmail: {_viewModel.Email}" +
                $"\nFaculty Number: {_viewModel.FacultyNumber}" +
                $"\nRole: {_viewModel.Role}");

        }

        public void DisplayErr()
        {
            throw new Exception("Error message");

        }
    }
}
