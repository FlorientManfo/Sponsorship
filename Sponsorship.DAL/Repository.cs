using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sponsorship.BO;
using OfficeOpenXml;

namespace Sponsorship.DAL
{

    public class Repository <T>
    {
        #region ExcelDataAccess
        protected List<T> data;
        protected ExcelPackage excel;
        protected ExcelWorksheet ws;

        public Repository(string path, int sheet)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            excel = new ExcelPackage(path);
            ws = excel.Workbook.Worksheets[sheet];
            data = new List<T>();
        }

        //Lecture des différentes informations dans les différentes cellules du document.
        public string ReadCell(int i, int j)
        {
            i++; j++;
            if (ws.Cells[i, j].Value != null)
                return ws.Cells[i, j].Value.ToString();
            return null;
        }

        //Inscription des informations dans les cellules

       
        #endregion

    }
}
