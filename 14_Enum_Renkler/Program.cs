namespace _14_Enum_Renkler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Enum: Numaratör ya da enum sabitleri olarak anladırılır.
             
             
             */
            Console.WriteLine(Renkler.Sarı);
            Console.WriteLine((int)Renkler.Sarı);
            Console.WriteLine("Renkler enumundaki değeleri okumak");
            foreach (int item in Enum.GetValues(typeof(Renkler)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('#',50));
            Console.WriteLine("Renkler enumundaki adları okumak için");
            foreach (string item in Enum.GetNames(typeof(Renkler)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string ('#',50));
            foreach (string item in Enum.GetNames<Renkler>())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('#', 50));
            Console.ReadLine();
        }
    }
}
