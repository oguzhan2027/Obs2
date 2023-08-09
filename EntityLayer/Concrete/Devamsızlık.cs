using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Devamsızlık
    {
        public int DevamsızlıkID { get; set; }
        public bool DevamsızlıkDurumu { get; set; }
        public int DersListesiID { get; set; }
        public DersListesi DersListesi { get; set; }
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci{ get; set; }
    }
}
