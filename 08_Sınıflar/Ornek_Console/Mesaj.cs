using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ornek_Console
{
    internal class Mesaj : Kisiler 
    {
        public void Metin()
        { 
            Console.WriteLine("Merhaba Kayseri");
            Console.WriteLine("Merhaba İstanbul");
        }
    }
}
