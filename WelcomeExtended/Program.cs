using Welcome.Model;
using WelcomeExtended.Data;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                UserData userData = new UserData();

                User student = new User()
                {
                    Name = "Pesho",
                    Password = "password",
                    Role = Welcome.Others.UserRolesEnums.STUDENT
                };
                userData.AddUser(student);

            }
            catch (Exception e)
            {
                var log = new ActionOnError(Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case");
            }
        }
    }
}
