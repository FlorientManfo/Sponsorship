using System;
using System.Collections.Generic;
using System.Drawing;
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
            try
            {
                BtnPause.Enabled = true;
                BtnPause.BackColor = Color.Blue;
                BtnStart.Enabled = false;
                BtnStart.BackColor = Color.Gray;
                while (seconds.Count != 0)
                {
                    Matching();
                }
                manager.Commit(matched);
            }
            catch(Exception ex)
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
            BtnStart.Enabled = true;
            BtnStart.BackColor = Color.Blue;
            BtnPause.Enabled = false;
            BtnPause.BackColor = Color.Gray;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            BtnPause.Enabled = false;
            BtnPause.BackColor = Color.Gray;
        }

        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

}
