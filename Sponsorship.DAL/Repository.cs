using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sponsorship.BO;
using OfficeOpenXml;
using System.IO;
using SerializationLibrary;

namespace Sponsorship.DAL
{

    public class Repository <T>
    {
        

        #region ExcelDataAccess
        protected ExcelPackage excel;
        protected ExcelWorksheet ws;
        protected List<T> excelDatas;

        public Repository(string list, int sheet)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            excel = new ExcelPackage(list);
            ws = excel.Workbook.Worksheets[sheet];
            excelDatas = new List<T>();
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
        ////assignation des identifients aléatoire et sans doublons
        //public static List<int> UnicRandom(int size)
        //{
        //    Random random = new Random();
        //    List<int> id = new List<int>();

        //    while (id.Count < size)
        //    {
        //        var a = random.Next(1, size+1);
        //        if (id.Contains(a) == false)
        //        {
        //            id.Add(a);
        //        }

        //    }
        //    return id;
            
        //}

        #endregion

        #region Save Datas
        private readonly string PATH=$"Data/{typeof(T).Name}.json";
        protected List<T> datas;
        Serializer<List<T>> serializer;
        public Repository()
        {
            datas = new List<T>();
            FileInfo fi = new FileInfo(PATH);

            if (!fi.Directory.Exists)
                fi.Directory.Create();
            else if(fi.Exists)
            {
                fi.Delete();
                fi.Create();
            }
            serializer = new Serializer<List<T>>(Mode.JSON, PATH, Format.Indented);
            Restore();
        }

        public int IndexOf(T Obj)
        {
            var index = -1;
            for (int i = 0; i < datas.Count; i++)
                if (Obj.Equals(datas[i]))
                    index = i;
            return index;
        }

        public void Add(T obj)
        {
            int index = IndexOf(obj);
            if (index != -1)
                throw new DuplicateWaitObjectException($"{typeof(T).Name} already exists !");

            datas.Add(obj);
            Save();
        }

        public void Set(T oldObj, T newObj)
        {
            int oldIndex = IndexOf(oldObj);
            if (oldIndex < 0)
                throw new KeyNotFoundException($"{typeof(T).Name} not found !");

            var newIndex = IndexOf(newObj);

            if (newIndex >= 0 && newIndex != oldIndex)
                throw new KeyNotFoundException($"{typeof(T).Name} already exists !");

            datas[oldIndex] = newObj;
            Save();
        }

        public void Delete(T obj)
        {
            var index = IndexOf(obj);

            if (index >= 0)
                datas.RemoveAt(index);
            Save();
        }

        public void Save()
        {
            serializer.Serialize(datas);
        }

        public void Restore()
        {
            FileInfo fi = new FileInfo(PATH);
            if (fi.Exists && fi.Length > 0)
                datas = serializer.Deserialize();
        }

        public List<T> GetAll()
        {
            Restore();
            T[] items = new T[datas.Count];
            datas.CopyTo(items);
            return items.ToList<T>();
        }
        #endregion
    }
}
