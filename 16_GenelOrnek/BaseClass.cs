using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_GenelOrnek
{
    public abstract class BaseClass
    {
		static int sayac = 1;
        public BaseClass()
        {
            _id = sayac;
            sayac++;
        }
        private int _id;

		public int Id
		{
			get { return _id; }
			private set {  }
		}
		//Dönücez
		private string _barkod;

		public string Barkod
		{
			get { return _barkod; }
			set { 

			bool kontrol = SanalDataBase.dbBarkodKontrol(value);

				if (kontrol) throw new Exception("Sanal Database içerisinde bu barkod daha önce girilmiş");
				else _barkod = value;                
            }
		}
		public DateTime OlusturmaTarihi { get; set; }


	}
}
