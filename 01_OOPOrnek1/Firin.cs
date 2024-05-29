using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPOrnek1
{
    public class Firin
    {
        public Firin()
        {
            Console.WriteLine("Fırın nesnesinden örnek alındı");
        }
        public Firin(string marka, string model,bool garantisiVarmi)
        {
            this.Marka = marka;
            this.Model = model;
            this.GarantiVarmi = garantisiVarmi;
        }

        public string Marka {  get; set; }
        public decimal Fiyat { get; set; }
        public string Guc {  get; set; }
        public string Model { get; set; }
        public int GarantiSuresi { get; set; }
        public bool GarantiVarmi { get; set; }
        public int MaxDerece {  get; set; }
        public void GarantiUzat(int uzatilanSure)
        {
            GarantiSuresi += uzatilanSure;
        }
    }
}
