using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sponsorship.WinForms
{
    public partial class FrmChoseLocationFile : Form
    {
        public FrmChoseLocationFile()
        {
            InitializeComponent();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Exel File|*.xlsx";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbListe.Text = fileDialog.FileName;
                Program.ListPath = fileDialog.FileName;
            }
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            //DirectoryInfo directoryInfo = new DirectoryInfo();
            //Directory.
            //var a = Directory.GetDirectories();

            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    tbImage.Text = fileDialog.FileName;
            //}
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
    }
}
