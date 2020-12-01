using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESCOM.BO
{
    [Serializable]
    public class COMPTOIR
    {
        public string Designation { get; set; }
        public string Code { get; set; }
        public int Quantite { get; set; }
        public float TVA{ get; set; }
        public double Prix { get; set; }
        public double TOTAL { get; set; }
        //public DateTime Date { get; set; }

        public COMPTOIR()
        {
        }

        public COMPTOIR( string designation, string code,  int quantite, float tva, double prix, double tataux/* DateTime date*/)
        {
            Designation = designation;
            Code = code;
            TVA = tva;
            Quantite = quantite;
            Prix = prix;
            TOTAL = tataux;
            //Date = date;
        }
        public override bool Equals(object obj)
        {
            return obj is COMPTOIR comptoir &&
                   Code == comptoir.Code;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Code);
        }

    }
}

