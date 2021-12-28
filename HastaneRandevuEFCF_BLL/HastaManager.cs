using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuEFCF_DAL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_BLL
{
    public class HastaManager
    {
        MyContext myDbContext = new MyContext();

        public List<Hasta> TumHastalariGetir()
        {
            try
            {
                return myDbContext.Hastalar.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Hasta> TcNosunaGöreHastayiBul(string tc)
        {
            try
            {
                return myDbContext.Hastalar.Where(x => x.TCNo.StartsWith(tc) || x.TCNo.EndsWith(tc)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
