using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterFaceOrnek
{
    internal class DikdortgenKutu : IUrun
    {
        public int KısaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int id { get; set; }
        public string UrunAd { get; set; }
        public int Yukseklik { get; set; }

        public int Hacim()
        {
            return Yukseklik * KısaKenar * UzunKenar;
        }
    }
}
