using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sponsorship.WinForms
{
    static class Program
    {
        public static string ListPath;
        public static string ImagePath;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmChoseLocationFile locationFile = new FrmChoseLocationFile();
            locationFile.Show();
            Application.Run();
        }
    }
}
