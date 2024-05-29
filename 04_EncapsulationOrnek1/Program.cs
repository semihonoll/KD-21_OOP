namespace _04_EncapsulationOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Field değer ataması yapılmasın ama değer okunsun 
            //Field değer ataması be okuma işlemleri yapılsın ama bu 2 işlem bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
            //Field değer ataması yapılsın ama değerin ilk 3 hanesini okusun
            Musteri musteri = new Musteri();
            //musteri.id = 9;
            musteri.Ad = "Gül";
            musteri.Soyad = "aRTman";
            try
            {
                musteri.TCKimlik = "3211311318";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(musteri.id);
            Console.WriteLine(musteri.TCKimlik);
            Console.ReadLine();
        }
    }
}
