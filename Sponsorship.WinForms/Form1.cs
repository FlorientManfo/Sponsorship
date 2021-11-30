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
            #region Last
            //manager = new Manager("test.xlsx");
            //manager2 = new Manager("test.xlsx");

            //level1secon = new List<FirstLevel>();
            //level1s = new List<FirstLevel>();
            //level2s = new List<SecondLevel>();
            //associes = new List<FirstLevel>();
            //parrain = 0;
            //duree = 100;
            ////recupération de tous les etudiants de PREPA 1 pour les mettres dans une liste

            //var contains = manager.GetFirstLevels();
            //var division = from firstStud in contains
            //               where firstStud.Faculty == "3IL"
            //               select firstStud;
            //level1s = division.ToList();

            ////recupération de tous les etudiants de TIC 1 pour les mettres dans une liste
            //var contains2 = manager2.GetFirstLevels();
            //var division2 = from stud in contains2
            //                where stud.Faculty == "TIC"
            //                select stud;
            //level1secon = division2.ToList();

            ////recupération de tous les etudiants de deuxieme année TIC/PREPA
            //level2s = manager.GetSecondLevels();
            //var leve2 = from stud in level2s
            //            orderby stud.Id ascending
            //            select stud;
            //level2s = leve2.ToList();
            #endregion

            InitializeComponent();
            manager = new Manager(Path.Combine(Application.StartupPath, Program.ListPath));
            secondLevels = new List<SecondLevel>();
            firstLevels = new List<FirstLevel>();
            associates = new List<SecondLevel>();
            sound = new SoundPlayer(@"resource\effet_tirage.wav");
        }
        private void tmrRecherche_Tick(object sender, EventArgs e)
        {
            if(firstLevels.Count != 0)
            {
                SecondLevel parrain = null;
                List<FirstLevel> filleuls = new List<FirstLevel>();
                (parrain, filleuls) = manager.Matching(secondLevels, firstLevels);
                pbParrain.ImageLocation = parrain?.Picture;
                pbParrain.Invalidate();
                lblParrain.Text = parrain.FullName;
                lblFiliereP.Text = parrain.Faculty;

                if (find != 10)
                {
                    if (filleuls.Count != 1)
                    {
                        pbFilleul1.ImageLocation = filleuls[0].Picture;
                        pbFilleul1.Invalidate();
                        pbFilleul2.ImageLocation = filleuls[1].Picture;
                        pbFilleul2.Invalidate();

                        lblFilleul1.Text = filleuls[0].FullName;
                        lblFilleul2.Text = filleuls[1].FullName;

                        lblFiliereFilleul1.Text = filleuls[0].Faculty;
                        lblFiliereFilleul2.Text = filleuls[1].Faculty;
                        
                    }
                    else
                    {
                        pbFilleul1.ImageLocation = filleuls[0].Picture;
                        pbFilleul1.Invalidate();
                        lblFilleul1.Text = filleuls[0].FullName;
                        lblFiliereFilleul1.Text = filleuls[0].Faculty;

                        pbFilleul2.ImageLocation = "../../Resources/unknow.png";
                        lblFilleul2.Text = "";
                        lblFiliereFilleul2.Text = "";
                    }

                    find++;

                }
                else
                {
                    sound.Stop();
                    int index = secondLevels.IndexOf(parrain);
                    foreach (var f in filleuls)
                    {
                        secondLevels[index].Filleuls.Add(f);
                        firstLevels.Remove(f);
                        Console.WriteLine(firstLevels.Count);
                    }
                    manager.Notify(secondLevels[index]);
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
                        associates.Add(p);

                manager.Commit(associates);
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
            tmrRecherche.Start();
            sound.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstLevels = manager.GetFirstLevels();
            secondLevels = manager.GetSecondLevels();
            find = 0;
        }
    }

}
