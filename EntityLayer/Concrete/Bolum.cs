using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bolum
    {
        public int BolumID { get; set; }
        public string BolumAdi { get; set; }
        public int FakulteID { get; set; }
        public Fakulte Fakulte { get; set; }
        public List<Ders> Derses { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
    }
}
