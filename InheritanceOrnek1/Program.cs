using _07_InheritanceOrnek1;

namespace InheritanceOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım: Bir sınıfa ait alanların, özelliklerin ve metotların kalıtım yoluyla diğer sınıflara aktarılmasına denir.
            //Kalıtımda iki kavram var 1-Temel Sınıf, 2-Türetilmiş Sınıf

            //Ogrenci ogrenci = new Ogrenci();
            //Ogrenci ogrenci2 = new Ogrenci("Gül");
            //ogrenci.BilgileriGoster();
            //ogrenci.MesajVer();
            //Console.ReadLine();

            OrtaOkulOgrenci ortaOkulOgrenci = new OrtaOkulOgrenci();
            ortaOkulOgrenci.kollar= "Kütüphane";
            ortaOkulOgrenci.MesajVer();
            Console.ReadLine();

        }
    }
}
