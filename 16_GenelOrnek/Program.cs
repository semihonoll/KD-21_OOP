namespace _16_GenelOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bilgisayar bilgisayar = new Bilgisayar()
                {
                    Marka = "Lenovo",
                    Model = "z50",
                    Islemci = "i5",
                    AlisFiyati = 20000,
                    SatisFiyati=23000,
                    KampanyaFiyati=22000,
                    Barkod="12345"
                
                };
                SanalDataBase.YeniUrunEkle(bilgisayar);
                Bilgisayar bilgisayar2 = new Bilgisayar()
                {
                    Marka = "Lenovo",
                    Model = "z50",
                    Islemci = "i5",
                    AlisFiyati = 20000,
                    SatisFiyati = 23000,
                    KampanyaFiyati = 22000,
                    Barkod = "123456"

                };
               Console.WriteLine( SanalDataBase.YeniUrunEkle(bilgisayar2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
    }
}
