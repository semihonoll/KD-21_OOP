using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_InterFaceOrnek
{
    public interface INotHesapla
    {
        public double GecmeNotu { get; set; }
        public double OgrenciOrtalama { get; set; }
        public void OgrenciDurumu(double puan);

    }
    public interface Ideneme
    {
        void Goster();
    }
    public class Insan
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


    }
    public class Ogrenci : Insan, INotHesapla, Ideneme
    {
        public double GecmeNotu { get; set; }
        public double OgrenciOrtalama { get;set;  }

        public void Goster()
        {
            throw new NotImplementedException();
        }

        public void OgrenciDurumu(double puan)
        {
            throw new NotImplementedException();
        }
        
        /*
         Formda datagridview yer alıcak
        IUrun isminde bir interface içerisinde id, ad, yukseklik propertyleri yer alıcak.
        hacim isminde geri dönüşü int olan bir metot olacak
        KupKutu ve DikdortgenKutu isminde 2 classımız olacak. bunlar IUrunden miras alacak
       DikdortgenKutu için
        hacimformulu = yukseklik* kısakenar*uzunkenar
        KupKutu için hacimformulu= yukseklik*yukseklik*yukseklik
         
         
         */
         
    }
}
