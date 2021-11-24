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
            var manager = new Manager("E:\\cours\\PAM2\\ProgrammationMulticouches\\Sponsorship\\Sponsorship.ConsoleApp\\bin\\Debug\\test.xlsx");

            List<FirstLevel> ticFirstLevel = manager.GetFirstLevels();

            Console.WriteLine("******************First Level********************");
            foreach (var student in ticFirstLevel)
            {

                Console.WriteLine(student.FullName);
                Console.WriteLine(student.Faculty);
                Console.WriteLine(student.Phone);
                Console.WriteLine(student.Email);

            }

            Console.WriteLine("\n****************Second Level********************");

            List<SecondLevel> ticSecondtLevel = manager.GetSecondLevels();
            foreach (var student in ticFirstLevel)
            {
                Console.WriteLine(student.FullName);
                Console.WriteLine(student.Faculty);
                Console.WriteLine(student.Phone);
                Console.WriteLine(student.Email);
            }

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

            Console.ReadKey();
        }
    }
}
