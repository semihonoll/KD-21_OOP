using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_HastaneOtomasyonu.Abstract
{
    public interface IInsan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
    }
}
