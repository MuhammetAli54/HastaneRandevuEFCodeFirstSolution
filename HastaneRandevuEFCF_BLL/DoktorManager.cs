using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuEFCF_DAL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_BLL
{
    public class DoktorManager
    {
      
        //Global alan
        MyContext myDBContext = new MyContext();
        public bool YeniDoktorEkle(Doktor yenidr)
        {
            try
            {
                //1. Yöntem
                myDBContext.Doktorlar.Add(yenidr);

                //2. Yöntem
                //myDBContext.Set<Doktor>().Add(yenidr); 

                myDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
        
        public List<Doktor> TumAktifDoktorlariGetir()
        {
            try
            {
                //where ile sadece aktifler çekilecek
                return myDBContext.Doktorlar.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Doktor> BransaGoreDoktorlariGetir(Branslar brans)
        {
            try
            {
                return myDBContext.Doktorlar.Where(x => x.Brans == brans).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
