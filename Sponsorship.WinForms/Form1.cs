using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sponsorship.BO;

namespace Sponsorship.WinForms
{

    public partial class Form1 : Form
    {
        List<FirstLevel> niveau1s;
        List<SecondLevel> niveau2s;
        List<FirstLevel> associes;
        int parrain;
        int filleul;
        int duree = 10;
        int rechercher = 10;
        public Form1()
        {
            InitializeComponent();
            //niveau1s = new List<FirstLevel>() { new Niveau1("Manfo", "tic", 'M', "manfoflorient@gmail.com", 1, null),new Niveau1("jiengap", "tic", 'M', "manfoflorient@gmail.com", 1, null)};
            //niveau2s = new List<SecondLevel>() { new Niveau2("rosvalde", "tic", 'M', "manfoflorient@gmail.com", 1), new Niveau2("jiengap", "tic", 'M', "manfoflorient@gmail.com", 1), new Niveau2("manfo", "tic", 'M', "manfoflorient@gmail.com", 1) };
            //associes = new List<FirstLevel>();
            //parrain = 0;
            //duree = 10;
        }

        private void tmrRecherche_Tick(object sender, EventArgs e)
        {
            //if(niveau1s.Count!=0)
            //{
            //    pbFilleul.ImageLocation = $"img{parrain}.jpg";
            //    pbParrain.Invalidate();

            //    lblFilière.Text = niveau2s[parrain].Filiere;
            //    lblParrain.Text = niveau2s[parrain].Nom;
            //    if (rechercher == 0)
            //    {
            //        filleul = new Random().Next(0, niveau1s.Count);
            //        tmrRecherche.Stop();
            //        niveau1s[filleul].Parrain = niveau2s[parrain];
            //        associes.Add(niveau1s[filleul]);
            //        niveau2s[parrain].Filleuls.Add(niveau1s[filleul]);
            //        duree = 10;
            //        tmrPresentation.Start();
            //    }
            //    else
            //    {
            //        filleul = new Random().Next(0, niveau1s.Count);
            //        lblFilleul.Text = niveau1s[filleul].Nom;
            //        rechercher--;

            //        pbFilleul.ImageLocation = $"img{filleul}.jpg";
            //        pbFilleul.Invalidate();

            //    }
            //}
            //else
            //{
            //    foreach (var item in niveau2s)
            //        Console.WriteLine(item.Filleuls.Count);
            //    tmrRecherche.Stop();
            //    Console.WriteLine(associes.Count);
            //}
        }

        private void tmrPresentation_Tick(object sender, EventArgs e)
        {
            //duree--;
            //if(duree != 0)
            //{
            //    lblParrain.Text = niveau2s[parrain].Nom;
            //    lblFilleul.Text = niveau1s[filleul].Nom;
            //    lblFilière.Text = niveau2s[parrain].Filiere;
            //}
            //else
            //{
            //    if (parrain != niveau2s.Count - 1 && niveau1s.Count>1)
            //        parrain++;
            //    else
            //        parrain = 0;

            //    rechercher = 10;
            //    niveau1s.RemoveAt(filleul);
            //    tmrPresentation.Stop();
            //    tmrRecherche.Start();
            //}
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //tmrRecherche.Start();
        }
    }
}
