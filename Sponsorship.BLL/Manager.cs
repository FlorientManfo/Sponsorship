using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
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
            else
                filleuls = null;

            //intialisation des informations de l'emetteur
            login = new NetworkCredential("émetteur@gmail.com", "mot de passe");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("émetteur@gmail.com", "IUC", Encoding.UTF8) };

            msg.To.Add(new MailAddress(etudiant.Email));
            msg.Subject = "Parrainage";

            if (etudiant.GetType() == typeof(SecondLevel))
            {
                var sLS = etudiant as SecondLevel;
                msg.Body = $"Vos filleuls se nomment:";

                for(int i = 0; i< sLS.Filleuls.Count; i++)
                {
                    msg.Body += $"\n{sLS.Filleuls[i].FullName} \n \tFilière: {sLS.Filleuls[i].Faculty} \n \tContact: {sLS.Filleuls[i].Phone}";
                    msg.Attachments.Add(new Attachment(sLS.Filleuls[i].Picture));
                }
            }
            else
            {
                msg.Body = $"Votre parrain se nomme: {etudiant.FullName}\nFilière: {etudiant.Faculty}\n \tContact: {etudiant.Phone}";
                msg.Attachments.Add(new Attachment(etudiant.Picture));
            }

            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendAsync(msg, "sending...");
        }
        #endregion

        #region Data manipulation

        private static int count = 0;
        FirstRepository firstRepository;
        SecondRepository secondRepository;
        Repository<Student> repository;

        private static int remainder;

        public Manager(string listPath, string imagePath)
        {
            firstRepository = new FirstRepository(listPath, 0, imagePath);
            secondRepository = new SecondRepository(listPath, 1, imagePath);
            repository = new Repository<Student>();

            remainder = firstRepository.GetALL().Count - secondRepository.GetALL().Count;
        }

        public List<FirstLevel> GetFirstLevels()
        {
            return firstRepository.GetALL();
        }

        public List<SecondLevel> GetSecondLevels()
        {
            return secondRepository.GetALL();
        }

        public void Notify(SecondLevel student)
        {
            try
            {
                SendMail(new SecondLevel(student));
                foreach(var f in filleuls)
                {
                    f.Parrain = student;
                    SendMail(f);
                }
                Console.WriteLine("mail send !");
            }
            catch
            {
                repository.Add(new Student(student));
            }
        }

        public void Commit(List<SecondLevel> students)
        {
            secondRepository.Commit(students);
        }


        public SecondLevel Matching(List<FirstLevel> firsts, List<SecondLevel> seconds)
        {
            if (firsts.Count == 0)
                return null;

            Random rand = new Random();
            SecondLevel second = new SecondLevel(seconds[rand.Next(0, seconds.Count)]);
           
            if(remainder > 0 && second.Filleuls.Count == 0)
            { 
                for( int i = 0; i<2; i++)
                {
                    if(i == 0)
                    {
                        var first = new FirstLevel(firsts[rand.Next(0, firsts.Count)]);
                        second.Filleuls.Add(first);
                        firsts.Remove(first);
                    }
                    else
                    {
                        FirstLevel first = null;
                        do
                        {
                            first = new FirstLevel(firsts[rand.Next(0, firsts.Count)]);
                        } while (first.Faculty == second.Filleuls[0].Faculty);
                        firsts.Remove(first);
                        second.Filleuls.Add(first);
                    }
                }
                remainder--;
                seconds.Remove(second);
                return second;
            }
            else
            {
                var first = new FirstLevel(firsts[rand.Next(0, firsts.Count)]);
                second.Filleuls.Add(first);
                firsts.Remove(first);
                seconds.Remove(second);

                if (remainder > 0)
                    remainder--;

                return second;
            }
        }


        #endregion
    }
}
