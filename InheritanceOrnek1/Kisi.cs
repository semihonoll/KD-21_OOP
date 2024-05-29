using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InheritanceOrnek1
{
    public class Kisi
    {
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        private double _boy;

        public double Boy
        {
            get { return _boy; }
            set { _boy = value; }
        }
        private string _cinsiyet;

        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }
        public Kisi()
        {
            Console.WriteLine("Ben temel sınıfın kurucusuyum");
        }
        public Kisi(string ad)
        {
            Console.WriteLine("Base classın parametreli kurucusuyum");
        }
        public void BilgileriGoster()
        {
            Console.WriteLine($"Kişinin adı {Ad}, Soyadı {Soyad}, boyu {Boy}, cinsiyet{Cinsiyet}");
        }
        //Virtual Metot: temel sınıflar içerisinde tanımlanan sanal metotlardır. Virtual metotlar türetilen sınıflarda override edilerek kullanılır.
        public virtual void MesajVer()
        {
            Console.WriteLine("Temel sınıfın virtual metodu");
        }
    }
}
