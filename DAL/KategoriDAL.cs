using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KategoriDAL
    {
        private readonly DataContext db;
        public KategoriDAL()
        {
            db = new DataContext();
        }
        public int Create(Kategori entity)
        {
            db.Kategoriler.Add(entity);
            return db.SaveChanges();
        }

        public int Update (Kategori entity)
        {
            return db.SaveChanges();
        }

        public int Delete(int id)
        {
            var entity = db.Kategoriler.Find(id);
            if (entity != null)
            {
                db.Kategoriler.Remove(entity);
                return db.SaveChanges();
            }
            return 0;
        }
        public List<Kategori> GetAll()
        {
            return db.Kategoriler.ToList();
        }
    }
}
