using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Kisiler
    {
        public void KisiListesi(string adSoyad)
        {          
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(adSoyad);
            }
        }
    }
}
