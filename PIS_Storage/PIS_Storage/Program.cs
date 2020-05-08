using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_Storage
{
    static class Program
    {
        /// Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            using(var db = new PIS_DbContext())
            {
                
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
