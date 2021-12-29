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
            fileDialog.Filter = "Excel File|*.xlsx";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbListe.Text = fileDialog.FileName;
                Program.List = fileDialog.FileName;
            }
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image File|*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbImage.Text = Path.GetDirectoryName(fileDialog.FileName);
                Program.ImagePath = tbImage.Text;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMain form1 = new FrmMain();
                form1.Show();
                this.Close();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show
                    (
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
            

        }
    }
}
