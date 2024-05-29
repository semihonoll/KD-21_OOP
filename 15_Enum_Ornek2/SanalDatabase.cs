using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Enum_Ornek2
{
    public static class SanalDatabase
    {
        static ArrayList db = new ArrayList();
        public static CustomerReturnValue CustomerAdd(Customer customer)
        {
            if (db.Count > 0)
            {
                foreach (Customer item in db)
                {
                    if (item.Id == customer.Id)
                    {
                        return CustomerReturnValue.KayıtBaşarısız;
                    }
                }
            }
           
            //Kontroller yapılacak
       
            db.Add(customer);
            return CustomerReturnValue.KayıtBaşarılı;
           
        }
    }
}
