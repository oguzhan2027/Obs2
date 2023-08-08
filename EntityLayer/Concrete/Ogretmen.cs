using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogretmen
    {
        public int OgretmenID { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }
        public string OgretmenTC { get; set; }
        public string OgretmenTel { get; set; }
        public string OgretmenAdres { get; set; }
        public List<Login> Logins { get; set; }
        public List<Ders> Derses { get; set; }
    }
}
