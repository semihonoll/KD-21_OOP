namespace _12_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Abstraction: OOP nin soyutlama ilkesidir. Bir sınıftan nesne üretmek mantıksız geliyorsa o sınıf soyutlanabilir.
            alt sınıfların ortak özelliklerini ve işlevlerini taşıyan ama nesne olmayan üst sınıf oluşturmak istersek abstract şeklinde üst sınıf oluşturabiliriz.            
             
             */

           // Tur tur = new Tur(); // Abstract sınıftan nesne üretilmez o yüzden hata verir
           Insan insan  = new Insan();
            insan.CanliTuru = "İnsan";
            insan.Aile = "Homo sapiens";
            insan.Familya = "sapiens sapiens";
            insan.TurGoster();
            insan.AileGoster();
            insan.FamilyaGoster();

            Hayvan  hayvan = new Hayvan();
            hayvan.CanliTuru = "Hayvan";
            hayvan.Aile = "pinus nigra";
            hayvan.Familya = "pinus";
            hayvan.TurGoster();
            hayvan.AileGoster();
            hayvan.FamilyaGoster();
            Console.ReadLine(); 
        }
    }
}
