using Sponsorship.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                var nS = new FirstLevel(ReadCell(i, 0), ReadCell(i, 1), int.Parse(ReadCell(i, 2)), ReadCell(i, 3), @"img\"+ReadCell(i, 0) + ".png");
                data.Add(nS);
                i++;
                item = ReadCell(i, 0);
            }
            return new List<FirstLevel>(data);
        }


        #endregion
    }
}
