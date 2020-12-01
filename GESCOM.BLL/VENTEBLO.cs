using GESCOM.BO;
using GESCOM.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;
//using GESCOM;



namespace GESCOM.BLL
{
    public class VENTEBLO
    {
        VENTEDAL REPO;
        public VENTEBLO(string dbfolder)
        {
            REPO = new VENTEDAL(dbfolder);
        }
        public void Commande(COMPTOIR comptoir)
        {
            REPO.add(comptoir);
        }
        public void DeleteCommande(COMPTOIR comptoir)
        {
            REPO.remove(comptoir);
        }
        public IEnumerable<COMPTOIR> getallcomptoir()
        {
            return REPO.find();
        }
        public IEnumerable<COMPTOIR> getreference(string reference)
        {
            return REPO.find(x => x.Code == reference);
        }
        public IEnumerable<COMPTOIR> getby(Func<COMPTOIR, bool> predicate)
        {
            return REPO.find(predicate);
        }

        //public void EditProduct(Product oldProduct, Product newProduct)
        //{
        //    productRepo.Set(oldProduct, newProduct);
        //}
    }
}
