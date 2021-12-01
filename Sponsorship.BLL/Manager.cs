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
            else
                filleuls = null;

            //intialisation des informations de l'emetteur
            login = new NetworkCredential("florientmanfo3@gmail.com", "toto_1234");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("florientmanfo3@gmail.com", "IUC", Encoding.UTF8) };

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

        FirstRepository firstRepository;
        SecondRepository secondRepository;
        public List<Student> notSent;


        public Manager(string paht)
        {
            firstRepository = new FirstRepository(paht, 0);
            secondRepository = new SecondRepository(paht, 1);
            notSent = new List<Student>();
        }

        public List<FirstLevel> GetFirstLevels()
        {
            return firstRepository.GetALL();
        }

        public List<SecondLevel> GetSecondLevels()
        {
            return secondRepository.GetALL();
        }

        public void Notify(Student student)
        {
            try
            {
                SendMail(student);
                Console.WriteLine("mail send !");
            }
            catch
            {
                notSent.Add(student);
            }
        }

        public void Commit(List<SecondLevel> students)
        {
            secondRepository.Commit(students);
        }

        //public (SecondLevel, List<FirstLevel>) Matching(List<SecondLevel> parrains, List<FirstLevel> filleuls)
        //{
        //    if(filleuls.Count != 0)
        //    {
        //        var f1rand = new Random().Next(0, filleuls.Count);
        //        var f2rand = new Random().Next(0, filleuls.Count);

        //        for (int i = 0; i < filleuls.Count - 1; i++)
        //        {
        //            for (int j = i + 1; j < filleuls.Count; j++)
        //            {
        //                if (filleuls[i].Faculty != filleuls[j].Faculty)
        //                {
        //                    while (filleuls[f1rand].Faculty == filleuls[f2rand].Faculty)
        //                    {
        //                        f1rand = new Random().Next(0, filleuls.Count);
        //                        f2rand = new Random().Next(0, filleuls.Count);
        //                    }
        //                    break;
        //                }
        //            }
        //            while (f1rand == f2rand && filleuls.Count>=2)
        //            {
        //                f1rand = new Random().Next(0, filleuls.Count);
        //                f2rand = new Random().Next(0, filleuls.Count);
        //            }
        //            break;
        //        }

        //        var hasAll = true;
        //        foreach (var par in parrains)
        //            if (par.Filleuls.Count == 0)
        //            {
        //                hasAll = false;
        //                break;
        //            }

        //        var prand = new Random().Next(0, parrains.Count);
        //        while (parrains[prand]?.Filleuls?.Count != 0)
        //        {
        //            if (!hasAll)
        //                prand = new Random().Next(0, parrains.Count);
        //            else
        //                break;
        //        }
        //        List<FirstLevel> f = new List<FirstLevel>();
        //        f.Add(filleuls[f1rand]);

        //        if (filleuls[f1rand] != filleuls[f2rand])
        //            f.Add(filleuls[f2rand]);

        //        return (parrains[prand], f);
        //    }
        //    return (null, null);
        //}

        public (SecondLevel, FirstLevel) Matching(List<SecondLevel> parrains, List<FirstLevel> filleuls)
        {
            if (filleuls.Count != 0)
            {
                var frand = new Random().Next(0, filleuls.Count);
                var hasAll = true;
                foreach (var par in parrains)
                    if (par.Filleuls.Count == 0)
                    {
                        hasAll = false;
                        break;
                    }

                var prand = new Random().Next(0, parrains.Count);
                while (parrains[prand]?.Filleuls?.Count != 0)
                {
                    if (!hasAll)
                        prand = new Random().Next(0, parrains.Count);
                    else
                        break;
                }
                return (parrains[prand], filleuls[frand]);
            }
            return (null, null);
        }


        #endregion


    }
}
