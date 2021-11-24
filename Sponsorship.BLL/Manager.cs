﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Sponsorship.BO;
using Sponsorship.DAL;

namespace Sponsorship.BLL
{

    public class Manager
    {
        

        #region MySqlDataAccess

        //List<Etudiant> students;
        //List<object[]> datas;
        //Repository repo;

        //public Manager()
        //{
        //    repo = new Repository("localhost", "test", "root", "");
        //    students = new List<Etudiant>();
        //    datas = new List<object[]>();
        //}

        ////Construction des objets etudiant de niveau2 à l'aides des données issus de la BD
        //public List<Etudiant> GetStudent()
        //{
        //    datas = repo.GetData("student", 0, 1);
        //    foreach (var data in datas)
        //    {
        //        Etudiant student = new Etudiant();
        //        for (int i = 0; i < data.Length; i++)
        //        {
        //            student = new Etudiant(data[1].ToString(), data[2].ToString(), char.Parse(data[3].ToString()), data[4].ToString());
        //        }
        //        students.Add(student);

        //    }

        //    return students;
        //}
        #endregion

        #region Email
        //attributs nécessaires à la construction du mail
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        List<FirstLevel> filleuls;
        public void SendMail(Student etudiant)
        {
            if (etudiant.GetType() == typeof(SecondLevel))
                filleuls = (etudiant as SecondLevel).Filleuls;

            //intialisation des informations de l'emetteur
            login = new NetworkCredential("florientmanfo3@gmail.com", "Anhedonia07");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("florientmanfo3@gmail.com", "IUC", Encoding.UTF8) };

            msg.To.Add(new MailAddress(etudiant.Email));
            msg.Subject = "Parrainage";

            if (etudiant.GetType() == typeof(SecondLevel))
            {
                client.SendCompleted += Client_SendCompleted;
                msg.Body = $"Votre filleul se nomme: {etudiant.Nom} ";
                //msgf.Attachments.Add(new Attachment("chemin vers la photo du filleul"));
            }
            else
            {
                msg.Body = $"Votre parrain se nomme: {etudiant.Nom} ";
                //msgf.Attachments.Add(new Attachment("chemin vers la photo du parrain"));
            }

            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendAsync(msg, "sending...");
        }

        private void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                Console.WriteLine("Cancelled");
            if(e.Error!= null)
                Console.WriteLine("Error");
            else
            {
                client.SendCompleted -= Client_SendCompleted;
                foreach (var etudiant in filleuls)
                    SendMail(etudiant);
                Console.WriteLine("Message has been successfully sent!");
            }
        }
        #endregion


        #region Manipulation des données

        FirstRepository firstRepository;
        SecondRepository secondRepository;

        public Manager(string paht)
        {
            firstRepository = new FirstRepository(paht, 0);
            secondRepository = new SecondRepository(paht, 1);
        }

        public List<FirstLevel> GetFirstLevels()
        {
            return firstRepository.GetALL();
        }

        public List<SecondLevel> GetSecondLevels()
        {
            return secondRepository.GetALL();
        }

        public void Notify(FirstLevel flStudent, SecondLevel sLStudent)
        {
            sLStudent.Filleuls.Add(flStudent);
            flStudent.Parrain = sLStudent;

            SendMail(sLStudent);
        }

        public void Commit(List<SecondLevel> students)
        {
            secondRepository.Commit(students);
        }
        #endregion
    }
}
