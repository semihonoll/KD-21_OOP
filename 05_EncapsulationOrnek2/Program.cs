namespace _05_EncapsulationOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir öğrenci nesnesi oluşacak. Ad,Soyad,Bolum,Sınıf,OgrenciNo prop. olacak.
            Girilen ad değeri set edilirken ilk harfi büyük olacak şekilde değişsin.
            Girilen soyad okunurken tüm harfleri büyük olarak ayarlansın. 
            Öğrenci no ya değer ataması yapılmasın. Öğrenci numarasına değer olarak Bölümün ilk harfinin büyük hali + Sınıfı + rastgele oluşan bir sayı atansın.           
             */

            Ogrenci ogrenci = new Ogrenci()
            {
                Ad = "semih",
                Soyad="önol",
                Bolum="yazılım",
                Sinif="21"

            };
            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine(ogrenci.Soyad);
            Console.WriteLine(ogrenci.OgrNo);
            Console.ReadLine();
         


        }
    }
}
