namespace _01_OOPOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firin firin = new Firin();
            firin.GarantiSuresi = 2;
            firin.Fiyat = 3500;
            firin.GarantiVarmi = false;
            firin.MaxDerece = 220;
            Console.WriteLine(firin.GarantiSuresi);
            firin.GarantiUzat(3);
            Console.WriteLine(firin.GarantiSuresi);
            Firin firin2 = new Firin("Siemens","fdjsd", true);
            Console.ReadLine();
        }
    }
}
