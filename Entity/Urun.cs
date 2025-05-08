using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }


        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
