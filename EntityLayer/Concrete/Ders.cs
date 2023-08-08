using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ders
    {
        public int DersID { get; set; }
        public string DersAdi { get; set; }
       
        public int OgretmenID { get; set; }
        public Ogretmen Ogretmen { get; set; }
        public int BolumID { get; set; }
        public Bolum Bolum { get; set; }
        public List<DersListesi> DersListesis { get; set; }
    }
}
