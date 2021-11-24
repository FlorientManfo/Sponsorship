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
            niveau1s = new List<FirstLevel>();
            niveau2s = new List<SecondLevel>();
            associes = new List<FirstLevel>();
            parrain = 0;
            duree = 10;
        }

        private void tmrRecherche_Tick(object sender, EventArgs e)
        {
            if (niveau1s.Count != 0)
            {
                lblFilière.Text = niveau2s[parrain].Faculty;
                lblParrain.Text = niveau2s[parrain].FullName;
                if (rechercher == 0)
                {
                    filleul = new Random().Next(0, niveau1s.Count);
                    tmrRecherche.Stop();
                    niveau1s[filleul].Parrain = niveau2s[parrain];
                    associes.Add(niveau1s[filleul]);
                    niveau2s[parrain].Filleuls.Add(niveau1s[filleul]);
                    duree = 10;
                    tmrPresentation.Start();
                }
                else
                {
                    filleul = new Random().Next(0, niveau1s.Count);
                    lblFilleul.Text = niveau1s[filleul].FullName;
                    rechercher--;

                }
            }
            else
            {
                foreach (var item in niveau2s)
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
                lblParrain.Text = niveau2s[parrain].FullName;
                lblFilleul.Text = niveau1s[filleul].FullName;
                lblFilière.Text = niveau2s[parrain].Faculty;
            }
            else
            {
                if (parrain != niveau2s.Count - 1 && niveau1s.Count > 1)
                    parrain++;
                else
                    parrain = 0;

                rechercher = 10;
                niveau1s.RemoveAt(filleul);
                tmrPresentation.Stop();
                tmrRecherche.Start();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrRecherche.Start();
        }
    }
}
