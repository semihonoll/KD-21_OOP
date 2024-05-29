namespace _15_Enum_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Semih",
                CustomerNo = "06",
                Email = "semihonoll@gmail.com",
            };
            CustomerReturnValue musteriKayitsonuc= SanalDatabase.CustomerAdd(customer);
            Console.WriteLine(musteriKayitsonuc);
            Console.WriteLine((int)musteriKayitsonuc);

            Customer customer2 = new Customer()
            {
                Id = 1,
                Name = "Melih",
                CustomerNo = "06",
                Email = "melihonoll@gmail.com",
            };
            CustomerReturnValue musteriKayitsonuc2 = SanalDatabase.CustomerAdd(customer);
            Console.WriteLine(musteriKayitsonuc2);
            Console.WriteLine((int)musteriKayitsonuc2);
            Console.ReadLine();

         
        }
    }
}
