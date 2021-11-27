using System;
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
            login = new NetworkCredential("mail de l'émetteur", "mot de passe");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("mail de l'émetteur", "IUC", Encoding.UTF8) };

            msg.To.Add(new MailAddress(etudiant.Email));
            msg.Subject = "Parrainage";

            if (etudiant.GetType() == typeof(SecondLevel))
            {
                client.SendCompleted += Client_SendCompleted;
                msg.Body = $"Votre filleul se nomme: {etudiant.FullName} ";
                //msgf.Attachments.Add(new Attachment("chemin vers la photo du filleul"));
            }
            else
            {
                msg.Body = $"Votre parrain se nomme: {etudiant.FullName} ";
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

        #region Data manipulation

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

        public SecondLevel Matching(List<SecondLevel> parrains, List<FirstLevel> filleuls)
        {
            if(filleuls.Count != 0)
            {
                var f1rand = new Random().Next(0, filleuls.Count);
                var f2rand = new Random().Next(0, filleuls.Count);

                for (int i = 0; i < filleuls.Count - 1; i++)
                {
                    for (int j = i + 1; j < filleuls.Count; j++)
                    {
                        if (filleuls[i].Faculty != filleuls[j].Faculty)
                        {
                            while (filleuls[f1rand].Faculty == filleuls[f2rand].Faculty)
                            {
                                f1rand = new Random().Next(0, filleuls.Count);
                                f2rand = new Random().Next(0, filleuls.Count);
                            }
                            break;
                        }
                    }
                    while (f1rand == f2rand && filleuls.Count>=2)
                    {
                        f1rand = new Random().Next(0, filleuls.Count);
                        f2rand = new Random().Next(0, filleuls.Count);
                    }
                    break;
                }

                var hasAll = true;
                foreach (var par in parrains)
                    if (par.Filleuls.Count == 0)
                    {
                        hasAll = false;
                        break;
                    }

                var prand = new Random().Next(0, parrains.Count);
                while (parrains[prand].Filleuls.Count != 0)
                {
                    if (!hasAll)
                        prand = new Random().Next(0, parrains.Count);
                    else
                        break;
                }

                parrains[prand].Filleuls.Add(filleuls[f1rand]);
                filleuls[f1rand].Parrain = parrains[prand];

                if (filleuls[f1rand].Email != filleuls[f2rand].Email)
                {
                    parrains[prand].Filleuls.Add(filleuls[f2rand]);
                    filleuls[f2rand].Parrain = parrains[prand];
                }

                return parrains[prand];
            }
            return null;
        }


        #endregion
    }
}
