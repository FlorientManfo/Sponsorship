using System;
using System.Windows.Forms;
using Sponsorship.BLL;

namespace Sponsorship.WinForms
{
    public static class Program
    {
        public static string List;
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
