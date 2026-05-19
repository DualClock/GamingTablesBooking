using GamingTablesBookingProject.Data;
using GamingTablesBookingProject.Forms;

namespace GamingTablesBookingProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}