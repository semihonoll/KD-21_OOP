using _19_HastaneOtomasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_HastaneOtomasyonu.Concrete
{
    public class Hastane: IHastane
    {
        public string HastaneAdi { get; set; }
        public int GunlukHastaSayisi { get; set; }
        public int CalisanSayisi { get; set; }
        public int YatakliServisSayisi { get; set; }
        public List<IDoktor> Doktorlar { get; set; }

        public Hastane()
        {
            Doktorlar = new List<IDoktor>();
        }
    }
}
