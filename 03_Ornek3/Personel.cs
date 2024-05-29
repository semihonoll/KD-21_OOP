using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ornek3
{
    public class Personel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime StartingDate { get; set; }
        public string Position{ get; set; }
        public string RegistrationNumber { get; set; }

        public Personel() 
        {
            StartingDate= DateTime.Now;
        }
        public Personel(string name)
        {
            this.Name = name;
            StartingDate = DateTime.Now;
        }
        public Personel(string name, string surName, DateTime startingDate,string position, string registrationNumber)
        {
            this.Name = name;
            this.SurName = surName;
            this.StartingDate = startingDate;
            this.Position = position;
            this.RegistrationNumber = registrationNumber;
        }

    }
}
