using _19_HastaneOtomasyonu.Abstract;
using _19_HastaneOtomasyonu.Enum_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_HastaneOtomasyonu.Concrete
{
    internal class OrtopediDoktor : IDoktor
    {
        public int GunlukHastaSayisi { get; set; }
        public int AylikNobetSayisi { get; set; }
        public string UzmanlikAlani { get; set; }
        private double _maas;
        public double Maas
        {
            get { return _maas; }
            set 
            { 
                _maas = value <20000 ? 25000 : value;

            }
        }
        
        public string Unvan { get; set; }
        private Birim _birim;
        public Birim Birim { get { return _birim; }
            set {

                _birim = value != Birim.Ortopedi ? Birim.Ortopedi : value;

            } }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public double DonerSermayeParasi { get; set; }

        public string AmeliyatYap()
        {
            return "Kırık Çıkık ameliyatı yapar platin takarım";
        }

        public string MuayeneEt()
        {
            return "Röntgen sonucunu inceleyip muayene edeceğim.";
        }

        public string ParaAl()
        {
            return $"Döner sermayeden alınan para {DonerSermayeParasi} , Toplam Kazanç = {_maas+DonerSermayeParasi}";
        }
    }
}
