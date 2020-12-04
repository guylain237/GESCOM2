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

        public AchatDAL(string dbfolder)
        {
            this.dbfolder = dbfolder;
            file = new FileInfo(Path.Combine(this.dbfolder, FILE_NAME));

    
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
        public void Set(Achat oldachat, Achat newachat)
        {
            var oldIndex = achats.IndexOf(oldachat);
            var newIndex = achats.IndexOf(newachat);
            if (oldIndex < 0)
                throw new KeyNotFoundException("L'ACHAT N'EXISTE PAS !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("Le code de produit existe deja !");
            achats[oldIndex] = newachat;
            Save();
        }

        public IEnumerable<Achat> Find()
        {
            return new List<Achat>(achats);
        }

        public void Add(Achat achat)
        {
            var index = achats.IndexOf(achat);
            if (index >= 0)
                throw new DuplicateNameException("Le code de produit existe deja !");
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

        public IEnumerable<Achat> Find(Func<Achat, bool> predicate)
        {
            return new List<Achat>( achats.Where(predicate).ToArray() );
        }
    }
}
