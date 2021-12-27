using OfficeOpenXml.Style;
using Sponsorship.BO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Sponsorship.DAL
{
    public class SecondRepository: Repository<SecondLevel>
    {
        #region ExceldatasAccess
        string imagePath = string.Empty;
        public SecondRepository(string list, int sheet, string imagePath) : base(list, sheet)
        {
            this.imagePath = imagePath;
        }

        //Récuperation des étudiants.
        public List<SecondLevel> GetALL()
        {
            int i = 1;
            string item = ReadCell(i, 0);
            while (!string.IsNullOrEmpty(item))
            {
                var nS = new SecondLevel(ReadCell(i, 0), ReadCell(i, 1), long.Parse(Regex.Replace(ReadCell(i, 2), @"\s", "")), ReadCell(i, 3), $@"{imagePath}\" + ReadCell(i, 0) + ".jpg" != null ? $@"{imagePath}\" + ReadCell(i, 0) + ".jpg" : "../../Resources/unknow.png");
                excelDatas.Add(nS);
                i++;
                item = ReadCell(i, 0);
            }
            return new List<SecondLevel>(excelDatas);
        }

        //Enregistrement des résultats du tirage
        public void Commit(List<SecondLevel> students)
        {

            OfficeOpenXml.ExcelWorksheet nws = excel.Workbook.Worksheets.Add("Result"); 

            var range = nws.Cells[1, 1, 1, 4];
            range.Merge = true;
            range.Value = "PARRAIN";
            nws.Cells[1, 1, 1, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[1, 1, 1, 4].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[1, 1, 1, 4].Style.Border.BorderAround(ExcelBorderStyle.Double);


            range = nws.Cells[1, 5, 1, 8];
            range.Merge = true;
            range.Value = "FILLEULS";
            nws.Cells[1, 5, 1, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[1, 5, 1, 8].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[1, 5, 1, 8].Style.Border.BorderAround(ExcelBorderStyle.Double);

            //En-tête pour les parrains
            nws.Cells[2, 1].Value = "NOM ET PRENOM";
            nws.Cells[2, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 1].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            nws.Cells[2, 2].Value = "FILIERE";
            nws.Cells[2, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 2].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 2].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            nws.Cells[2, 3].Value = "TELEPHONE";
            nws.Cells[2, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 3].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 3].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            nws.Cells[2, 4].Value = "EMAIL";
            nws.Cells[2, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 4].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 4].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            //En-têtes pour les filleuls
            nws.Cells[2, 5].Value = "NOM ET PRENOM";
            nws.Cells[2, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 5].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 5].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            nws.Cells[2, 6].Value = "FILIERE";
            nws.Cells[2, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 6].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 6].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            nws.Cells[2, 7].Value = "TELEPHONE";
            nws.Cells[2, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 7].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 7].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            nws.Cells[2, 8].Value = "EMAIL";
            nws.Cells[2, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            nws.Cells[2, 8].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            nws.Cells[2, 8].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            int n = 2;
            for (int i = 0; i<students.Count; i++)
            {
                range = nws.Cells[n + 1, 1, n + students[i].Filleuls.Count, 1];
                range.Merge = true;
                range.Value = students[i].FullName;

                range = nws.Cells[n + 1, 2, n + students[i].Filleuls.Count, 2];
                range.Merge = true;
                range.Value = students[i].Faculty;

                range = nws.Cells[n + 1, 3, n  + students[i].Filleuls.Count, 3];
                range.Merge = true;
                range.Value = students[i].Phone;

                range = nws.Cells[n + 1, 4, n + students[i].Filleuls.Count, 4];
                range.Merge = true;
                range.Value = students[i].Email;

                nws.Cells[n + 1, 1, n  + students[i].Filleuls.Count, 4].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                nws.Cells[n + 1, 2, n + students[i].Filleuls.Count, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                nws.Cells[n + 1, 1, n + students[i].Filleuls.Count, 4].Style.Border.BorderAround(ExcelBorderStyle.Medium);

                for (int j = n, k = 0; j< students[i].Filleuls.Count + n; j++, k++)
                {
                    nws.Cells[j+1, 5].Value = students[i].Filleuls[k].FullName??null;
                    nws.Cells[j+1, 6].Value = students[i].Filleuls[k].Faculty ?? null;
                    nws.Cells[j + 1, 7].Value = students[i].Filleuls[k].Phone;
                    nws.Cells[j + 1, 8].Value = students[i].Filleuls[k].Email ?? null;

                    nws.Cells[j + 1, 6, j + 1, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    nws.Cells[j + 1, 5, j + 1, 8].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    nws.Cells[j + 1, 5, j + 1, 8].Style.Border.BorderAround(ExcelBorderStyle.Medium);
                }
                n += students[i].Filleuls.Count;
            }
            excel.Save();
        }
        #endregion
    }
}
