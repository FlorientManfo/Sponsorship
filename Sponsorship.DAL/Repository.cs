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

        #region MySqlDataAccess

        //protected list<object[]> datas;
        //mysqlconnection cnx;
        //public repository(string host, string database, string user, string password)
        //{
        //    cnx = new mysqlconnection($"server = {host}; database = {database}; uid = {user}; pwd = {password}");
        //    datas = new list<object[]>();
        //}

        //public list<object[]> getdata(string tablename, int startindex, int endindex)
        //{
        //    try
        //    {
        //        cnx.open();
        //        string query = $"select * from {tablename} limit {endindex - startindex + 1} offset {startindex};";
        //        mysqlcommand cmd = new mysqlcommand(query, cnx);
        //        mysqldatareader datareader = cmd.executereader();
        //        object[] values = new object[datareader.fieldcount];

        //        while (datareader.read())
        //        {
        //            datareader.getvalues(values);
        //            datas.add(values);
        //            datareader.nextresult();
        //        }

        //        cnx.close();
        //        return new list<object[]>(datas);
        //    }
        //    catch(exception ex)
        //    {
        //        console.writeline(ex.message);
        //        return null;
        //    }
        //}
        #endregion
    }
}
