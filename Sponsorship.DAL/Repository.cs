using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sponsorship.BO;
using OfficeOpenXml;
using System.IO;
using LibraryGenericSerialiser;

namespace Sponsorship.DAL
{

    public class Repository <T>
    {
        private readonly string PATH;
        private Serializer<List<T>> serializer;
        #region ExcelDataAccess
        protected List<T> data;
        protected ExcelPackage excel;
        protected ExcelWorksheet ws;

        public Repository(string path, int sheet)
        {
            PATH = $"Data/{typeof(T).Name}.json";
            FileInfo fi = new FileInfo(PATH);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
            serializer = new Serializer<List<T>>(Mode.JSON,PATH);
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
        #region  RANDOM
        //assignation des identifients aléatoire et sans doublons
        public static List<int> UnicRandom(List<int> id, Random random)
        {
            while (id.Count < 20)
            {
                var a = random.Next(0, 20);
                if (id.Contains(a) == false)
                {
                    id.Add(a);
                }

            }
            return id;
            
        }

        #endregion
        public void Save()
        {
            serializer.Serialize(data);
        }

    }
}
