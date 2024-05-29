using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _12_Abstraction
{
    public abstract class Tur
    {
        public Tur()
        {
            Console.WriteLine("Abstract Class Ctor");
        }
        public string CanliTuru { get; set; }
        public string Familya { get; set; }
        public string Aile { get; set; }
        public virtual void TurGoster() 
        {
            Console.WriteLine($"Tanımlanan Canlı Türü: ");
        }
        public void AileGoster()
        {
            Console.WriteLine($"Tanımlanan Canlının Ailesi {Aile}");
        }
        public abstract void FamilyaGoster();

    }
    public class Insan : Tur
    {
        //public override void TurGoster()
        //{
        //    base.TurGoster();
        //}
        public override void FamilyaGoster()
        {
            Console.WriteLine($"İnsan sınıfının familyası {Familya}");
        }
    }
    public class Hayvan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine($"Hayvan sınıfının familyası {Familya}");
        }
        public override void TurGoster()
        {
            Console.WriteLine("Base Halini ezdim");
        }
    }
}
