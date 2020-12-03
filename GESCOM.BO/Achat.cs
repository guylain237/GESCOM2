using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GESCOM.BO;

namespace GESCOM.BO
{
    [Serializable]
   public class Achat
    {
        public string Code { get; set; }
        public string Designation { get; set; }
        public string Fournisseur { get; set; }
        public string Nfacture { get; set; }
        public string Quantite { get; set; }

        public Achat()
            {
            }

        public Achat(string code, string designation, string fournisseur, string nfacture, string quantite)
        {
            Code = code;
            Designation = designation;
            Fournisseur = fournisseur;
            Nfacture = nfacture;
            Quantite = quantite;
        }

        public override bool Equals(object obj)
        {
            return obj is Achat achat &&
                   Code == achat.Code;
        }

        public override int GetHashCode()
        {
            return -434485196 + EqualityComparer<string>.Default.GetHashCode(Code);
        }
    }
}
