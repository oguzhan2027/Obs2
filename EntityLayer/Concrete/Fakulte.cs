using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Fakulte
    {
        public int FakulteID { get; set; }
        public string FakulteAdi { get; set; }
        public List<Bolum> Bolums { get; set; }
    }
}
