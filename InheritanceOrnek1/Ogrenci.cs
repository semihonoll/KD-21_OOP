using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InheritanceOrnek1
{
    public class Ogrenci : Kisi
    {
        private int _ogrNo;

        public int OgrenciNo
        {
            get { return _ogrNo; }
            set { _ogrNo = value; }
        }
        private string _fakulte;

        public string Fakulte
        {
            get { return _fakulte; }
            set { _fakulte = value; }
        }
        private string _bolum;

        public string Bolum
        {
            get { return _bolum; }
            set { _bolum = value; }
        }
        public Ogrenci() : base()
        {
            Console.WriteLine("Türetilmiş sınıfın kurucu metoduyum");
        }
        public Ogrenci(string ad) : base(ad)
        {
            Console.WriteLine("Bu türetilmiş sınıfın parametreli kurucu metodu");
        }
        public override void MesajVer()
        {
            //
            //base.MesajVer();
            Console.WriteLine("Türetilen sınıfta ovveride edilmiş haliyle kullandım");
        }
    }
}
