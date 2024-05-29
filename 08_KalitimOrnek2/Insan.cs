using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KalitimOrnek2
{
    public class Insan
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string DogumTarihi { get; set; }
        public string TC { get; set; }

        public virtual void BilgileriAl()
        {
            Console.WriteLine("Adı:");
            Adı = Console.ReadLine();
            Console.WriteLine("Soyadı:");
            Soyadı = Console.ReadLine();
            Console.WriteLine("Doğum Tarihi (yyyy/aa/gg):");
            DogumTarihi = (Console.ReadLine());
            Console.WriteLine("TC:");
            TC = Console.ReadLine();
        }
        public virtual void BilgileriGoster()
        {
            Console.WriteLine($"Adı: {Adı} Soyadı: {Soyadı} Doğum tarihi:{DogumTarihi} TC: {TC}");
           
        }
    }
}
