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
        List<FirstLevel> level1s;
        List<SecondLevel> level2s;
        List<FirstLevel> associes;
        int parrain;
        int filleul;
        int duree = 10;
        int rechercher = 10;
        public Form1()
        {
            InitializeComponent();
            level1s = new List<FirstLevel>();
            level2s = new List<SecondLevel>();
            associes = new List<FirstLevel>();
            parrain = 0;
            duree = 10;
        }

        private void tmrRecherche_Tick(object sender, EventArgs e)
        {
            if (level1s.Count != 0)
            {
                lblFilière.Text = level2s[parrain].Faculty;
                lblParrain.Text = level2s[parrain].FullName;
                if (rechercher == 0)
                {
                    filleul = new Random().Next(0, level1s.Count);
                    tmrRecherche.Stop();
                    level1s[filleul].Parrain = level2s[parrain];
                    associes.Add(level1s[filleul]);
                    level2s[parrain].Filleuls.Add(level1s[filleul]);
                    duree = 10;
                    tmrPresentation.Start();
                }
                else
                {
                    filleul = new Random().Next(0, level1s.Count);
                    lblFilleul.Text = level1s[filleul].FullName;
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
            tmrRecherche.Start();
        }
    }
}
