using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesaj msj = new Mesaj();
            PersonID Id = new PersonID();

            string ads, isim, soyisim, meslek;

            msj.Metin();

            Console.WriteLine("Hello World!");
            Console.WriteLine("-------------------------------------------");

            msj.KisiListesi("Emir Özkul");
            msj.KisiListesi("Esra Özkul");
            Console.WriteLine("-------------------------------------------");

            Console.Write("Lütfen ismi giriniz: ");
            ads = Console.ReadLine();
            msj.KisiListesi(ads);
            Console.WriteLine("-------------------------------------------");

            Console.Write("İsminizi giriniz: ");
            isim = Console.ReadLine();
            Console.Write("Soyisminizi giriniz: ");
            soyisim = Console.ReadLine();
            Console.Write("Mesleğinizi giriniz: ");
            meslek = Console.ReadLine();

            Id.KisiBiligleri(isim, soyisim, meslek);


            Console.ReadLine();

        }
    }
}
