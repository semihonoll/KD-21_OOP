namespace _03_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Ctor metodu ile çalışanın adı, soyadı, göreve başlama tarihi, birimi ve Sicil Numarası bilgilerini alan programı yazınız.
            Çalışan sınıfından nesne üretildiği zaman göreve başlama tarihine eklendiği andaki o an ki tarih saat atansın.
            Çalışan sınıfından nesne üretildiği zaman göreve başlama tarihine eklendiği andaki tarih atanacak ve aynı zamanda nesne üretilirken çalışanın adını alarak
            üretilen parametreli ctor olacak. 
            Tüm bilgileri alarak nesne üretilsin.
             
             
             
             
             
             
             
             
             */

            Personel personel = new Personel();
            Personel personel2 = new Personel("Semih");
            Personel personel3 = new Personel("Semih","Önol",DateTime.Now,"KD-21","12345678");
        }
    }
}
