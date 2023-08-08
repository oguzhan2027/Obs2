using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Login
    {
        public int LoginID { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public bool LoginRole { get; set; }
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int OgretmenID { get; set; }
        public Ogretmen Ogretmen { get; set; }
    }
}
