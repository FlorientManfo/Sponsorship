using Sponsorship.BO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Sponsorship.DAL
{
    public class FirstRepository: Repository<FirstLevel>
    {
        #region ExcelDataAccess
        string imagePath = string.Empty;
        public FirstRepository(string list, int sheet, string imagePath) : base(list, sheet)
        {
            this.imagePath = imagePath;
        }

        //Récuperation des étudiants.
        public List<FirstLevel> GetALL()
        {
            int i = 1;
            string item = ReadCell(i, 0);
            while (!string.IsNullOrEmpty(item))
            {
                var nS = new FirstLevel(ReadCell(i, 0), ReadCell(i, 1), long.Parse(Regex.Replace(ReadCell(i, 2), @"\s", "")), ReadCell(i, 3), $@"{imagePath}\" + ReadCell(i, 0) + ".jpg" != null ? $@"{imagePath}\" + ReadCell(i, 0) + ".jpg" : "../../Resources/unknow.png");
                excelDatas.Add(nS);
                i++;
                item = ReadCell(i, 0);
            }
            return new List<FirstLevel>(excelDatas);
        }


        #endregion
    }
}
