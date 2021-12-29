using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
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
        List<SecondLevel> results;
        SoundPlayer sound;

        private bool stop = false;
        Thread t;

        public FrmMain()
        {
            InitializeComponent();
            
        }

        [Obsolete]
        private void FrmMain_Load(object sender, EventArgs e)
        {
            BtnRestart.Enabled = false;
            BtnPause.Enabled = false;
            manager = new Manager(Program.List, Program.ImagePath);
            seconds = manager.GetSecondLevels();
            firsts = manager.GetFirstLevels();
            results = new List<SecondLevel>();
            sound = new SoundPlayer(@"..\..\Resources\effet_tirage.wav");
            t = new Thread(Process);
        }

        [Obsolete]
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (t.ThreadState == ThreadState.Suspended)
                t.Resume();
            else
            {
                t = new Thread(Process);
                t.Start();
            }

            stop = false;
            BtnPause.Enabled = true;
            BtnStart.Enabled = false;
            BtnStart.Text = "Continue";
        }

        [Obsolete]
        private void BtnPause_Click(object sender, EventArgs e)
        {
            stop = true;
            t.Suspend();
            BtnPause.Enabled = false;
            BtnStart.Enabled = true;
            
        }

        [Obsolete]
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            if (t.ThreadState == ThreadState.Suspended)
                t.Resume();
            t.Abort();
            FrmMain_Load(sender, e);
            BtnStart_Click(sender, e);
        }

        [Obsolete]
        private void Process()
        {
            while (firsts.Count != 0)
            {
                if (stop)
                    break;

                Reset();
                Random rand = new Random();
                SecondLevel matched = manager.Matching(firsts, seconds);
                int count = 0;

                while (count < 50)
                {
                    PrintPicture(seconds[rand.Next(0, seconds.Count)], pbParrain);
                    PrintText(seconds[rand.Next(0, seconds.Count)], lblNomP, lblFiliereP);
                    count++;
                    Console.WriteLine(matched.FullName);
                    Console.WriteLine(matched.Filleuls.Count);
                }
                if(count == 50)
                {
                    PrintPicture(matched, pbParrain);
                    PrintText(matched, lblNomP, lblFiliereP);
                    seconds.Remove(matched);
                }

                while (count < 100)
                {
                    PrintPicture(firsts[rand.Next(0, firsts.Count)], pbFilleul1);
                    PrintText(firsts[rand.Next(0, firsts.Count)], lblNomF1, lblFiliereF1);
                    count++;
                }
                if(count == 100)
                {
                    PrintPicture(matched.Filleuls[0], pbFilleul1);
                    PrintText(matched.Filleuls[0], lblNomF1, lblFiliereF1);
                    firsts.Remove(matched.Filleuls[0]);
                }

                if (matched.Filleuls.Count == 2)
                {
                    while (count < 150)
                    {
                        PrintPicture(firsts[rand.Next(0, firsts.Count)], pbFilleul2);
                        PrintText(firsts[rand.Next(0, firsts.Count)], lblNomF2, lblFiliereF2);
                        count++;
                    }
                    if(count == 150)
                    {
                        PrintPicture(matched.Filleuls[1], pbFilleul2);
                        PrintText(matched.Filleuls[1], lblNomF2, lblFiliereF2);
                        firsts.Remove(matched.Filleuls[1]);
                    }
                }
                manager.Notify(matched);
                results.Add(matched);
                Thread.Sleep(5000);
            }
            if(firsts.Count == 0)
                manager.Commit(results);
        }

        private void Reset()
        {
            Student st = new Student("?", "?", 000000, "?", @"../../Resources/unknow.png");

            PrintPicture(st, pbParrain);
            PrintText(st, lblNomP, lblFiliereP);

            PrintPicture(st, pbFilleul1);
            PrintText(st, lblNomF1, lblFiliereF1);

            PrintPicture(st, pbFilleul2);
            PrintText(st, lblNomF2, lblFiliereF2);
        }

        private void PrintText(Student student, Label name, Label faculty)
        {
            if (InvokeRequired)
            {
                this.Invoke
                (
                    new Action
                    (
                        () => {
                            name.Text = student.FullName;
                            name.Refresh();
                            faculty.Text = student.Faculty;
                            faculty.Refresh();
                        }
                    )
                );
            }
            else
            {
                name.Text = student.FullName;
                name.Refresh();
                faculty.Text = student.Faculty;
                faculty.Refresh();
            }
        }

        private void PrintPicture(Student student, PictureBox pictureBox)
        {
            if (InvokeRequired)
            {
                this.Invoke
                (
                    new Action
                    (
                        () => {
                            pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(student.Picture) != null ? File.ReadAllBytes(student.Picture) : File.ReadAllBytes(@"../../Resources/unknow.png")));
                            pictureBox.Refresh();
                        }
                    )
                );
            }
            else
            {
                pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(student.Picture)!= null ? File.ReadAllBytes(student.Picture): File.ReadAllBytes(@"../../Resources/unknow.png")));
                pictureBox.Refresh();
            }
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        [Obsolete]
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (t.ThreadState == ThreadState.Suspended)
                t.Resume();
            t.Abort();
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }

}
