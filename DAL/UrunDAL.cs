using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UrunDAL
    {
        private readonly DataContext db;
        public UrunDAL()
        {
            db = new DataContext();
        }
        public int Create(Urun entity)
        {
            db.Urunler.Add(entity);
            return db.SaveChanges();
        }

        public int Update(Urun entity)
        {
            return db.SaveChanges();
        }

        public int Delete(int id)
        {
            var entity = db.Urunler.Find(id);
            if (entity != null)
            {
                db.Urunler.Remove(entity);
                return db.SaveChanges();
            }
            return 0;
        }

        public List<Urun> GetAll()
        {
            return db.Urunler.ToList();
        }

    }
}
