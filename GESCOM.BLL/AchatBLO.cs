using GESCOM.BO;
using GESCOM.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESCOM.BLL
{
   public class AchatBLO
    {
        AchatDAL achatRepo;
        public AchatBLO()
        {
            achatRepo = new AchatDAL(); 
        }
      public void AjouterAchat(Achat achat)
        {
            achatRepo.Add(achat);
        }

        public void SupprimerAchat(Achat achat)
        {
            achatRepo.Remove(achat);
        }

        public IEnumerable<Achat> GetAllAchats()
        {
            return achatRepo.Find();
        }
    }
}
