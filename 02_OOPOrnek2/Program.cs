namespace _02_OOPOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir öğrenci nesnesi oluşturup Ad, soyad, doğum tarihi,sınıfı,cinsiyet bilgilerini tutunuz.Öğrenci nesnesini ad soyad bilgileri ile yaratınız.aynı zamanda öğrenci clasında gelen doğum tarihi bilgisine göre yıl bazında yaş hesaplayan bir metod olacak.
            //yine class içerisinde oluşan bir metotla öğrenci bilgilerini ekrana yazınız. ekranda yaş bilgisini de metottan çağırarak kullanınız. program cs den nesne oluşturup bilgileri ekrana yazınız.

            Ogrenci ogrenci1 = new Ogrenci("Semih", "Önol");
            ogrenci1.BirthDate = new DateTime(1999, 07, 21);
            ogrenci1.Class = "KD-21";
            ogrenci1.OgrenciBilgileriniYaz();
        }
    }
}
