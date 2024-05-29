using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_GenelOrnek
{
    public static class SanalDataBase
    {
        public static ArrayList db = new ArrayList();

        public static bool dbBarkodKontrol(string barkod)
        {
            bool kontrol = false;
            if(db!=null && db.Count > 0)
            {
                foreach(BaseClass item in db) 
                {
                    if(item.Barkod==barkod)
                    {
                        kontrol = true;
                        break;
                    }
                }
            }
            return kontrol;
        }
        public static Result YeniUrunEkle(BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Barkod))
            {
                db.Add(data);
                return Result.KayıtBasarılı;
            }
            else return Result.KayıtBasarısız;
        }
    }
}
