using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using Sponsorship.BLL;
using Sponsorship.BO;

namespace Sponsorship.WinForms
{

    public partial class FrmMain : Form
    {

        Manager manager;
        List<SecondLevel> seconds;
        List<FirstLevel> firsts;
        List<SecondLevel> matched;
        SoundPlayer sound;

        public FrmMain()
        {
            InitializeComponent();

            manager = new Manager(Program.List, Program.ImagePath);
            seconds = manager.GetSecondLevels();
            firsts = manager.GetFirstLevels();
            matched = new List<SecondLevel>();
            sound = new SoundPlayer(@"..\..\Resources\effet_tirage.wav");

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            while (seconds.Count != 0)
            {
                Matching();
            }
            manager.Commit(matched);
        }

        private void Matching()
        {
            SecondLevel student = manager.Matching(firsts, seconds);
            seconds.Remove(student);
            foreach (var st in student.Filleuls)
            {
                if (firsts.Contains(st))
                    firsts.Remove(st);
            }
            matched.Add(student);
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

    }

}
