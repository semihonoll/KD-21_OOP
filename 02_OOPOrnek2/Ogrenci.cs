using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOPOrnek2
{
    public class Ogrenci
    {
        
        public Ogrenci (string name, string surName)
        {
            Name=name;
            SurName = surName;
        }
        public string Name {  get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Class {  get; set; }
        public bool Gender { get; set; }

        private int Age()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        public void OgrenciBilgileriniYaz()
        {
            Console.WriteLine($"{Class} sınıfındaki {Name} {SurName} isimli {(Gender ? "Kız" : "Erkek")} öğrencinin yaşı {Age()} ");
        }

    }
    
}
