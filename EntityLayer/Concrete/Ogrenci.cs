using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciTC { get; set; }
        public string OgrenciTel { get; set; }
        public string OgrenciAdres { get; set; }
        public int BolumID { get; set; }
        public Bolum Bolum { get; set; }
        public List<DersListesi> DersListesis { get; set; }
        public List<Devamsızlık> Devamsızlıks { get; set; }

    }
}
