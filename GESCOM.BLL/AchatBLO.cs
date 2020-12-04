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
        public AchatBLO(string dbfolder)
        {
            achatRepo = new AchatDAL(dbfolder); 
        }

        //public AchatBLO(string v)
        //{
        //}

        public void Command(Achat achat)
        {
            achatRepo.Add(achat);
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

        public IEnumerable<Achat> Getby(Func<Achat, bool> predicate)
        {
            return achatRepo.Find(predicate);
        }

        

        public static implicit operator AchatBLO(Action v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator AchatBLO(Achat v)
        {
            throw new NotImplementedException();
        }

        public void AJOUTAchat(Achat oldachat, Achat newachat)
        {
            achatRepo.Set(oldachat, newachat);
        }

        public void AJOUTAchat(AchatBLO oldachat, Achat newachat)
        {
            throw new NotImplementedException();
        }
    }
}
