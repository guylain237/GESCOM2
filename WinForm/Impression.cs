using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
  public  class Impression
    {
        public string Designation { get; set; }
        public string Code { get; set; }
        public int Quantite { get; set; }
        public float TVA { get; set; }
        public double Prix { get; set; }
        public double TOTAL { get; set; }

        public Impression()
        {
        }

       
 
      
        public Impression(string code, string designation, int quantite, double prix, float tVA, double tOTAL)
        {
            Code = code;
            Designation = designation;
            Quantite = quantite;
            Prix = prix;
            TVA = tVA;
            TOTAL = tOTAL;
        }
    }
}
