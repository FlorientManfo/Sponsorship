using Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using Sponsorship.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sponsorship.DAL
{
    public class SecondRepository: Repository<SecondLevel>
    {
        #region ExcelDataAccess
        public SecondRepository(string path, int sheet) : base(path, sheet)
        {
        }

        //Récuperation des étudiants.
        public List<SecondLevel> GetALL()
        {
            int i = 0;
            string item = ReadCell(i, 0);
            while (!string.IsNullOrEmpty(item))
            {
                var nS = new SecondLevel(ReadCell(i, 0), ReadCell(i, 1), int.Parse(ReadCell(i, 2)), ReadCell(i, 3));
                data.Add(nS);
                i++;
                item = ReadCell(i, 0);
            }
            return new List<SecondLevel>(data);
        }

        public void Commit(List<SecondLevel> students)
        {
            int n = 0;
            var nws = excel.Workbook.Worksheets.Add("Associeted");
            for (int i = 0; i<students.Count; i++)
            {
                var range = nws.Cells[n + 1, 1, n + students[i].Filleuls.Count, 1];
                range.Merge = true;
                range.Value = students[i].FullName;

                range = nws.Cells[n + 1, 2, n + students[i].Filleuls.Count, 2];
                range.Merge = true;
                range.Value = students[i].Faculty;

                range = nws.Cells[n + 1, 3, n + students[i].Filleuls.Count, 3];
                range.Merge = true;
                range.Value = students[i].Phone;

                range = nws.Cells[n + 1, 4, n + students[i].Filleuls.Count, 4];
                range.Merge = true;
                range.Value = students[i].Email;

                nws.Cells[n + 1, 1, n + students[i].Filleuls.Count, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                nws.Cells[n + 1, 1, n + students[i].Filleuls.Count, 4].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                nws.Cells[n + 1, 1, n + students[i].Filleuls.Count, 4].Style.Border.BorderAround(ExcelBorderStyle.Medium);

                for (int j = n, k = 0; j< students[i].Filleuls.Count + n; j++, k++)
                {
                    nws.Cells[j+1, 5].Value = students[i].Filleuls[k].FullName;
                    nws.Cells[j+1, 6].Value = students[i].Filleuls[k].Faculty;
                    nws.Cells[j + 1, 7].Value = students[i].Filleuls[k].Phone;
                    nws.Cells[j + 1, 8].Value = students[i].Filleuls[k].Email;

                    nws.Cells[j + 1, 5, j + 1, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    nws.Cells[j + 1, 5, j + 1, 8].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    nws.Cells[j + 1, 5, j + 1, 8].Style.Border.BorderAround(ExcelBorderStyle.Medium);
                }
                n = students[i].Filleuls.Count;
            }
            excel.Save();
        }
        #endregion
    }
}
