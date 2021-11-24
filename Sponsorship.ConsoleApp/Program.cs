using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sponsorship.BLL;
using Sponsorship.BO;

namespace Sponsorship.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager("E:\\cours\\PAM2\\ProgrammationMulticouches\\Sponsorship\\Sponsorship.ConsoleApp\\bin\\Debug\\test (2).xlsx");

            List<FirstLevel> ticFirstLevel = manager.GetFirstLevels();
            foreach (var student in ticFirstLevel)
            {
                Console.WriteLine("**************************************");

                Console.WriteLine(student.Nom);
                Console.WriteLine(student.Filiere);
                Console.WriteLine(student.Telephone);
                Console.WriteLine(student.Email);

            }

            Console.WriteLine("\n****************Second Level********************");

            List<SecondLevel> ticSecondtLevel = manager.GetSecondLevels();
            foreach (var student in ticFirstLevel)
            {
                Console.WriteLine(student.Nom);
                Console.WriteLine(student.Filiere);
                Console.WriteLine(student.Telephone);
                Console.WriteLine(student.Email);

                Console.WriteLine("**************************************");
            }

            ticSecondtLevel[0].Filleuls = ticFirstLevel;
            ticSecondtLevel[1].Filleuls = ticFirstLevel;
            try
            {
                manager.Commit(ticSecondtLevel);
                Console.WriteLine("Commited success fully !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured !");
                Console.WriteLine(ex.Message);

            }
            Console.WriteLine();
            //List < Etudiant > etudiants = man.GetStudent();
            //foreach (var etudiant in etudiants)
            //{
            //    Console.WriteLine(etudiant.Nom);
            //    Console.WriteLine(etudiant.Specialite);
            //    Console.WriteLine(etudiant.Genre);
            //    Console.WriteLine(etudiant.Email);
            //    Console.WriteLine(etudiant.Parrain);
            //}

            Console.ReadKey();
        }
    }
}
