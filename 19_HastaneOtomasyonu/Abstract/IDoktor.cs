using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_HastaneOtomasyonu.Abstract
{
    public interface IDoktor:ICalisan,IInsan,IEkParaAl
    {
        string AmeliyatYap();
        string MuayeneEt();
        public int GunlukHastaSayisi { get; set; }
        public int AylikNobetSayisi { get; set; }
        public string UzmanlikAlani { get; set; }
    }
}
