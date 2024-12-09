using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyedenGirilen2Sayiya4Islem
{
    internal class matematikIslemleri
    {
        public (int toplam, int fark, int carpim, int bolum) mathislem(double s1, double s2)
        {
  
            int toplam = Convert.ToInt32(s1 + s2);
            int fark = Convert.ToInt32(s1 - s2);
            int carpim = Convert.ToInt32(s1 * s2);
            int bolum = Convert.ToInt32(s1 / s2);

            return (toplam, fark, carpim, bolum);


        }
    }
}
