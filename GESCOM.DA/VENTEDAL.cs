using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GESCOM.DA;

using GESCOM.BO;
using System.IO;
using Newtonsoft.Json;

namespace GESCOM.DA
{
    public class VENTEDAL
    {
        private static List<COMPTOIR> comptoirs;
        private const string FILE_NAME = @"comptoirs.json";
        private readonly string dbfolder;
        private FileInfo file;
        public VENTEDAL(string dbfolder)
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
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    comptoirs = JsonConvert.DeserializeObject<List<COMPTOIR>>(json);
                }
            }
            if (comptoirs == null)
            {
                comptoirs = new List<COMPTOIR>();
            }

        }
        public void Set(COMPTOIR oldCOMPTOIR, COMPTOIR newCOMPTOIR)
        {
            var oldIndex = comptoirs.IndexOf(oldCOMPTOIR);
            var newIndex = comptoirs.IndexOf(newCOMPTOIR);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The comptoir doesn't exists !");
            //if (newIndex >= 0 && oldIndex != newIndex)
            //    throw new DuplicateNameException("This comptoir reference already exists !");
            comptoirs[oldIndex] = newCOMPTOIR;
            save();
        }



        public void add(COMPTOIR comptoir)
        {
            var index = comptoirs.IndexOf(comptoir);
            //if (index >= 0)
            //    throw new DuplicateNameException("This comptoir reference already exists !");

            comptoirs.Add(comptoir);
            save();

        }

        private void save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName,false))
            {
                string json = JsonConvert.SerializeObject(comptoirs);
                sw.WriteLine(json);
            }
        }

        public void remove(COMPTOIR comptoir)
        {
            comptoirs.Remove(comptoir);//base sur comptoir.equals redefini
            save();
        }
        public IEnumerable<COMPTOIR> find()
        {
            return new List<COMPTOIR>(comptoirs);

        }
        public IEnumerable<COMPTOIR> find(Func<COMPTOIR, bool> predicate)
        {
            return new List<COMPTOIR>(comptoirs.Where(predicate).ToArray());

        }





    }
}

