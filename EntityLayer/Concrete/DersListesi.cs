using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DersListesi
    {
        public int DersListesiID { get; set; }
        public int DersID { get; set; }
        public Ders Ders { get; set; }
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
