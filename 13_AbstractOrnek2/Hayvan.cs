using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AbstractOrnek2
{
    public abstract class Hayvan
    {
        protected Hayvan()
        {
            
        }
        public string Adi { get; set; }
        public string Cinsi { get; set; }
        public string YasadigiYer { get; set; }
        public string Cinsiyet { get; set; }

        public abstract void CikardigiSes();
        

        
    }
}
