using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KategoriServis
    {
        private readonly KategoriDAL kategoriDAL;

        public KategoriServis()
        {
            kategoriDAL = new KategoriDAL();
        }

        public List<Kategori> GetAll()
        {
            return kategoriDAL.GetAll();
        }




    }
}
