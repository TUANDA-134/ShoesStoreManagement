using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreManagement.BLL;
using ShoesStoreManagement.UI;

namespace ShoesStoreManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mainform mainform = new Mainform();
            Login login = new Login(mainform);
            Application.Run(login);
            //if (login.IsSuccessful)
            //{
            //    mainform.GetHienHanh(BLL_Login.HienHanh());
            //    Application.Run(mainform);
            //}
            
        }
    }
}
