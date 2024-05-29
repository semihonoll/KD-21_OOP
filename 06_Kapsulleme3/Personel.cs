using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Kapsulleme3
{
    public class Personel
    {

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
            get { return _soyad; }
            set
            {
                _soyad = value.Substring(value.Length - 2, 2).ToUpper().PadLeft(value.Length, '*');

            }
        }

        private string _tc;

        public string TC
        {
            get { return _tc; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("TC 11 Karakter olmalıdır.");
                }
                else
                {
                    foreach (char item in value)
                    {
                        if (!char.IsNumber(item))
                        {
                            throw new Exception("TC rakamlardan oluşmalıdır.");
                        }
                    }
                    _tc = value.Substring(0, 2).PadRight(value.Length, '*');
                }
            }
        }


    }
}
