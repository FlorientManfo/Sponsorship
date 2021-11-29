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
            //var manager = new Manager("test.xlsx");

            //List<FirstLevel> firstLevel = manager.GetFirstLevels();

            //Console.WriteLine("******************First Level********************");
            //foreach (var student in firstLevel)
            //{

            //    Console.WriteLine(student.FullName);
            //    Console.WriteLine(student.Faculty);
            //    Console.WriteLine(student.Phone);
            //    Console.WriteLine(student.Email);

            //}

            //Console.WriteLine("\n****************Second Level********************");

            //List<SecondLevel> secondtLevel = manager.GetSecondLevels();
            //foreach (var student in firstLevel)
            //{
            //    Console.WriteLine(student.FullName);
            //    Console.WriteLine(student.Faculty);
            //    Console.WriteLine(student.Phone);
            //    Console.WriteLine(student.Email);
            //}


            //try
            //{
            //    SecondLevel parrain = null;
            //    while (firstLevel.Count != 0)
            //    {
            //        parrain = manager.Matching(secondtLevel, firstLevel);

            //        if (parrain != null)
            //        {
            //            foreach (var f in parrain.Filleuls)
            //                firstLevel.Remove(f);
            //            //manager.Notify(parrain);
            //        }
            //    }
            //    List<SecondLevel> associed = new List<SecondLevel>();
            //    foreach (var st in secondtLevel)
            //        if (st.Filleuls.Count != 0)
            //            associed.Add(st);

            //    manager.Commit(associed);
            //    Console.WriteLine("Commited success fully !");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occured !");
            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadKey();
        }
    }
}
