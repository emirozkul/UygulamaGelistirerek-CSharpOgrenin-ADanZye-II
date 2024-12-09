using klavyedenGirilen2Sayiya4Islem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace klavyeenGirilen2Sayiya4islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
          matematikIslemleri islemler = new matematikIslemleri();

          Console.Write("1. sayıyı giriniz: ");
          double s1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("2. sayıyı giriniz: ");
          double s2 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Toplam: " + islemler.mathislem(s1, s2).toplam);
          Console.WriteLine("Fark: " + islemler.mathislem(s1, s2).fark);
          Console.WriteLine("Çarpım: " + islemler.mathislem(s1, s2).carpim);
          Console.WriteLine("Bölüm: " + islemler.mathislem(s1, s2).bolum);

          Console.Read();
        }
    }
}