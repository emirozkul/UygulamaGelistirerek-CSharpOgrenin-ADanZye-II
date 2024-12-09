using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            islem toplam = new islem();

            string ads, isim, soyisim, meslek;
            int sayi1, sayi2, sonuc;

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

            Console.WriteLine("-------------------------------------------");
            Console.Write("Toplanılacak birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Toplanılacak ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            sonuc = toplam.topla(sayi1, sayi2);
            Console.WriteLine("Toplam: " + sonuc);


            Console.ReadLine();

        }
    }
}
