using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _04_EncapsulationOrnek1
{

    public class Musteri
    {
        public Musteri()
        {
            IdAtama();
        }

        private void IdAtama()
        {
            Random rnd = new Random();
            _id = rnd.Next(1000, 9000);
        }

        private int _id;

        public int id
        {
            get { return _id; }
            private set { _id = value; } //erişimi kapattık değer atılamaz 
        }

        public string Ad { get; set; }
        private string _soyad { get; set; }

        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set
            {
                _soyad = value;
                _email = string.Format("{0}.{1}@gmail.com", Ad, _soyad);
            }

        }

        private string _email;
        public string Email
        {
            get { return _email; }
            private set { }
        }

        private string _tc;

        public string TCKimlik
        {
            get
            {
                return _tc.Substring(0, 3).PadRight(11, '*');
            }
            set
            {

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterkontrol = char.IsNumber(value[i]);
                        if (!karakterkontrol)
                        {
                            throw new Exception("Rakamdan oluşmuyor");
                        }
                        else
                            _tc = value;
                    }
                }
                else
                    throw new Exception("11 haneden oluşmuyor");
            }
        }

    }
}
