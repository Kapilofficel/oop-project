using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Views;
using UnicomTICManagementSystem.Repositories;

namespace Unicom_TIC_Management_System__UMS_
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseManager.InitializeDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

    internal class loginform : Form
    {
    }
}
