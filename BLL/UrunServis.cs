using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UrunServis
    {
        private readonly UrunDAL urunDAL;
        public UrunServis()
        {
            urunDAL = new UrunDAL();
        }
        public int Create(Urun entity)
        {
            return urunDAL.Create(entity);
        }

        public List<Urun> GetAll()
        {
            return urunDAL.GetAll();
        }
    }
}
