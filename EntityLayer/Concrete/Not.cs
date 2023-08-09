using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Not
    {
        public int NotID { get; set; }
        public int VizeNotu { get; set; }
        public int FinalNotu { get; set; }
        public Decimal Ortalama { get; set; }
        public int DersListesiID { get; set; }
        public DersListesi DersListesi { get; set; }
    }
}
