using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
   public class ImpAchat
    {
        public string Code { get; set; }
        public string Designation { get; set; }

        public string NFacture { get; set; }
         public string Fournisseur { get; set; }
        public string Quantite { get; set; }
        public string prix { get; set; }

        public ImpAchat(string code, string designation, string nFacture, string fournisseur, string quantite, string prix)
        {
            Code = code;
            Designation = designation;
            NFacture = nFacture;
            Fournisseur = fournisseur;
            Quantite = quantite;
            this.prix = prix;
        }

        public ImpAchat(string code, string designation, string quantite, string fournisseur, string nfacture)
        {
            Code = code;
            Designation = designation;
            Quantite = quantite;
            Fournisseur = fournisseur;
            NFacture = nfacture;
        }
    }
}
