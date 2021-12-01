using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sponsorship.BLL;
using Sponsorship.BO;

namespace Sponsorship.WinForms
{

    public partial class Form1 : Form
    {

        Manager manager;
        List<SecondLevel> secondLevels;
        List<FirstLevel> firstLevels;
        List<SecondLevel> associates;
        int find;
        SoundPlayer sound;
        public Form1()
        {
            InitializeComponent();
            manager = new Manager(Path.Combine(Application.StartupPath, Program.ListPath));
            secondLevels = new List<SecondLevel>();
            firstLevels = new List<FirstLevel>();
            associates = new List<SecondLevel>();
            sound = new SoundPlayer(@"..\..\Resources\effet_tirage.wav");
        }
        private void tmrRecherche_Tick(object sender, EventArgs e)
        {
            if (firstLevels.Count != 0)
            {
                #region Last
                //SecondLevel parrain = null;
                //List<FirstLevel> filleuls = new List<FirstLevel>();
                //(parrain, filleuls) = manager.Matching(secondLevels, firstLevels);
                //pbParrain.ImageLocation = parrain?.Picture;
                //pbParrain.Invalidate();
                //lblParrain.Text = parrain.FullName;
                //lblFiliereP.Text = parrain.Faculty;

                //if (find != 10)
                //{
                //    if (filleuls.Count != 1)
                //    {
                //        pbFilleul1.ImageLocation = filleuls[0].Picture;
                //        pbFilleul1.Invalidate();
                //        pbFilleul2.ImageLocation = filleuls[1].Picture;
                //        pbFilleul2.Invalidate();

                //        lblFilleul1.Text = filleuls[0].FullName;
                //        lblFilleul2.Text = filleuls[1].FullName;

                //        lblFiliereFilleul1.Text = filleuls[0].Faculty;
                //        lblFiliereFilleul2.Text = filleuls[1].Faculty;
                //    }
                //    else
                //    {
                //        pbFilleul1.ImageLocation = filleuls[0].Picture;
                //        pbFilleul1.Invalidate();
                //        lblFilleul1.Text = filleuls[0].FullName;
                //        lblFiliereFilleul1.Text = filleuls[0].Faculty;

                //        pbFilleul2.ImageLocation = "../../Resources/unknow.png";
                //        lblFilleul2.Text = "";
                //        lblFiliereFilleul2.Text = "";
                //    }

                //    find++;

                //}
                //else
                //{
                //    sound.Stop();
                //    int index = secondLevels.IndexOf(parrain);
                //    foreach (var f in filleuls)
                //    {
                //        secondLevels[index].Filleuls.Add(f);
                //        firstLevels.Remove(f);
                //        Console.WriteLine(firstLevels.Count);
                //        f.Parrain = parrain;
                //        manager.Notify(f);
                //    }
                //    tmrPresentation.Start();
                //    tmrRecherche.Stop();
                //}
                #endregion

                
                SecondLevel parrain = null;
                FirstLevel filleul = null;
                (parrain, filleul) = manager.Matching(secondLevels, firstLevels);
                pbParrain.ImageLocation = parrain?.Picture;
                pbParrain.Invalidate();
                lblParrain.Text = parrain.FullName;
                lblFiliereP.Text = parrain.Faculty;

                if (find != 10)
                {
                    pbFilleul1.ImageLocation = filleul.Picture;
                    pbFilleul1.Invalidate();
                    lblFilleul1.Text = filleul.FullName;
                    lblFiliereFilleul1.Text = filleul.Faculty;
                    find++;
                }
                else
                {
                    sound.Stop();
                    int index = secondLevels.IndexOf(parrain);

                    secondLevels[index].Filleuls.Add(filleul);
                    firstLevels.Remove(filleul);
                    filleul.Parrain = parrain;
                    manager.Notify(filleul);
                    tmrPresentation.Start();
                    tmrRecherche.Stop();

                }
            }
            else
            {
                tmrRecherche.Stop();
                sound.Stop();
                foreach (var p in secondLevels)
                    if (p.Filleuls.Count != 0)
                    {
                        associates.Add(p);
                        manager.Notify(p);
                    }

                manager.Commit(associates);
                Console.WriteLine(manager.notSent.Count);
                MessageBox.Show("Tirage terminé !", "Information", MessageBoxButtons.OK);
            }
        }

        private void tmrPresentation_Tick(object sender, EventArgs e)
        {
            find--;
            if (find == 0)
            {
                tmrPresentation.Stop();
                tmrRecherche.Start();
                sound.Play();
            }
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sound.Play();
            tmrRecherche.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstLevels = manager.GetFirstLevels();
            secondLevels = manager.GetSecondLevels();
            find = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
