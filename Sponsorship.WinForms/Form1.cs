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
        List<FirstLevel> level1s;
        List<FirstLevel> level1secon;
        List<SecondLevel> level2s;
        List<FirstLevel> associes;
        int parrain;
        int filleul;
        int filleul2;
        int duree = 100;
        int rechercher = 30;
        Manager manager;
        Manager manager2;

        Random random = new Random();


        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public Form1()
        {
            manager = new Manager("test.xlsx");
            manager2 = new Manager("test.xlsx");
            InitializeComponent();
            level1secon = new List<FirstLevel>();
            level1s = new List<FirstLevel>();
            level2s = new List<SecondLevel>();
            associes = new List<FirstLevel>();
            parrain = 0;
            duree = 100;
            //recupération de tous les etudiants de PREPA 1 pour les mettres dans une liste

            var contains  = manager.GetFirstLevels();
            var division = from firstStud in contains
                           where firstStud.Faculty =="PREPA"
                           select firstStud;
            level1s = division.ToList();

            //recupération de tous les etudiants de TIC 1 pour les mettres dans une liste
            var contains2 = manager2.GetFirstLevels();
            var division2 = from stud in contains2
                            where stud.Faculty !="PREPA"
                           select stud;
            level1secon = division2.ToList();

            //recupération de tous les etudiants de deuxieme année TIC/PREPA
            level2s = manager.GetSecondLevels();
            var leve2 = from stud in level2s
                      orderby stud.Id ascending
                      select stud;
            level2s = leve2.ToList();
        }
        private void tmrRecherche_Tick(object sender, EventArgs e)
        {
            if (level1s.Count != 0)
            {
                lblFilière.Text = level2s[parrain].Faculty;
                lblParrain.Text = level2s[parrain].FullName;
                pbParrain.ImageLocation = level2s[parrain].Picture;
                if (rechercher == 0)
                {
                    filleul = new Random().Next(0, level1s.Count);
                    filleul2 = new Random().Next(0, level1s.Count);
                    tmrRecherche.Stop();
                    level1s[filleul].Parrain = level2s[parrain];
                    level1secon[filleul2].Parrain = level2s[parrain];
                    associes.Add(level1s[filleul]);
                    level2s[parrain].Filleuls.Add(level1s[filleul]);
                    duree = 5;

                    tmrPresentation.Start();
                }
                else
                {
                    filleul = new Random().Next(0, level1s.Count);
                    lblFilleul.Text = level1s[filleul].FullName;
                    lbFillole2.Text = level1secon[filleul].FullName;
                    rechercher--;
                    

                }
            }
            else
            {
                foreach (var item in level2s)
                    Console.WriteLine(item.Filleuls.Count);
                tmrRecherche.Stop();
                Console.WriteLine(associes.Count);
            }

            

        }

        private void tmrPresentation_Tick(object sender, EventArgs e)
        {
            duree--;
            if (duree != 0)
            {
                lblParrain.Text = level2s[parrain].FullName;
                lblFilleul.Text = level1s[filleul].FullName;
                lblFilière.Text = level2s[parrain].Faculty;
                lbFillole2.Text = level1secon[filleul].FullName;

            }
            else
            {
                if (parrain != level2s.Count - 1 && level1s.Count > 1)
                    parrain++;
                else
                    parrain = 0;

                rechercher = 10;
                level1s.RemoveAt(filleul);
                tmrPresentation.Stop();
                tmrRecherche.Start();
            }
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( level1s.Count.ToString());
            tmrRecherche.Start();

        }

        private void lblFilleul_TextChanged(object sender, EventArgs e)
        {
            pbFilliole1.ImageLocation = level1s[filleul].Picture;
        }
        public void playsimplesound(string path)
        {
            SoundPlayer simplesound = new SoundPlayer(path);
            simplesound.Play();
        }

        private void lblParrain_TextChanged(object sender, EventArgs e)
        {
            playsimplesound("sound.wav");
        }

        private void lbFillole2_TextChanged(object sender, EventArgs e)
        {
            pbFilliole2.ImageLocation = level1secon[filleul].Picture;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.saveResult(associes);
        }
    }
    //add sound in winform


}
