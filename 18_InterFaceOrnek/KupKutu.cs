using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterFaceOrnek
{
    public class KupKutu : IUrun
    {
        public int id { get; set; }
        public string UrunAd { get; set; }
        public int Yukseklik { get; set; }

        public int Hacim()
        {
            return (int)Math.Pow(Yukseklik, 3);
        }
    }
}
