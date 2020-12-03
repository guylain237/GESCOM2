using System;
using System.Collections.Generic;
using System.Linq;
using GESCOM.BO;
using Newtonsoft.Json;

using System.Data;
using System.IO;

using System.Text;
using System.Threading.Tasks;
using GESCOM.DA;


namespace GESCOM.DA
{
    public class AchatDAL
    {
        private static List<Achat> achats;
        private const string FILE_NAME = @"Achats.json";
        private readonly string dbfolder;
        private FileInfo file;

        public AchatDAL()
        {
            file = new FileInfo(FILE_NAME);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using(StreamReader sr=new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    achats = JsonConvert.DeserializeObject<List<Achat>>(json);
                }
            }
            if (achats == null)
            {
                achats = new List<Achat>();
            }
        }
        public void Add(Achat achat)
        {
            achats.Add(achat);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(achats);
                sw.WriteLine(json);
            }
        }

        public void Remove(Achat achat)
        {
            achats.Remove(achat);
            Save();
        }

        public IEnumerable<Achat> Find()
        {
            return new List<Achat>( achats );
        }
    }
}
