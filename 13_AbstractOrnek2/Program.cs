namespace _13_AbstractOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Temel class olarak nesne üretilmeyen hayvan adında bir classınız olsun. Türetilen sınıflar kedi ve köpek olsun hayvan classında cinsi, adı, yaşadığı yer,cinsiyet proportyleri ve çıkardığı ses metodu sınıflarda zorunlu olarak uygulansın kedi ve köpek nesnesi üretilsin. Bilgileri atansın çıkardığı ses metodu hayvanın çıkardığı sese göre ekrana yazsın.
                        
             */
            Kedi kedi = new Kedi();
            kedi.Adi = "Minnoş";
            kedi.Cinsiyet = "erkek";
            kedi.YasadigiYer = "Ankara";
            kedi.CikardigiSes();

            Kopek kopek = new Kopek();
            kopek.Adi = "Cabbar";
            kopek.Cinsiyet = "Erkek";
            kopek.YasadigiYer = "Ankara";
            kopek.CikardigiSes();
            Console.ReadLine();
        }
    }
}
