using Sponsorship.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sponsorship.DAL
{
    public class FirstRepository: Repository<FirstLevel>
    {
        #region ExcelDataAccess
        public FirstRepository(string path, int sheet) : base(path, sheet)
        {
        }

        //Récuperation des étudiants.
        public List<FirstLevel> GetALL()
        {
            List<int> id = new List<int>();
            Random random = new Random();

            UnicRandom(id, random);
            int i = 0;
            string item = ReadCell(i, 0);
            while (!string.IsNullOrEmpty(item))
            {
                var nS = new FirstLevel(ReadCell(i, 0), ReadCell(i, 1), long.Parse(Regex.Replace(ReadCell(i, 2), @"\s", "")), ReadCell(i, 3), @"img\"+ReadCell(i, 0) + ".png");
                excelDatas.Add(nS);
                i++;
                item = ReadCell(i, 0);
            }
            return new List<FirstLevel>(excelDatas);
        }


        #endregion
    }
}
