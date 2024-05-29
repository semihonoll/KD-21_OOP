using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_HastaneOtomasyonu.Abstract
{
    public interface IHemsire:IInsan,ICalisan,IEkParaAl
    {
        void IgneVur();
        void HastadanKanAl();
        void HastayaSerumTak();
        void PansumanYap();
        public int AylikNobetSayisi { get; set; }
    }
}
