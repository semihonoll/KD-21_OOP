using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EncapsulationOrnek2
{
    public class Ogrenci
    {
        int sayi;
        public Ogrenci()
        {
            Random rnd = new Random();
            sayi = rnd.Next(1000, 9999);
        }
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set
            {
                _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        private string _soyad;

        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set { _soyad = value; }
        }
        public string Bolum { get; set; }
        public string Sinif { get; set; }
        private string _ogrNo;

        public string OgrNo
        {
            get
            {
                _ogrNo = Bolum.Substring(0, 1).ToUpper() + Sinif+sayi;


                return _ogrNo;
            }
            private set { }
        }


    }

}
