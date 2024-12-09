using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using KimilkSinifOrnek;

namespace KimlikSinifOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();

            kml.AD = "emir";
            kml.SOYAD = "özkul";
            kml.MEMLEKET = "kayseri";
            kml.YAS = 25;
            kml.Cinsiyet = 'E';

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.Cinsiyet);

            Console.Read();

        }
    }
}