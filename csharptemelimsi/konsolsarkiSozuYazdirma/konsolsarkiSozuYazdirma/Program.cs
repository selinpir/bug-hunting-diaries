using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;

//sarkı sozlerini ekrana yazdirma
//Thread.Sleep()  o satıra geldiğinde devam etmeden önce belirttiğin süre kadar durmasını sağlar.
namespace konsolsarkiSozuYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            HarfHarfYaz("Nasıl birisin", 100);
            Thread.Sleep(1500);
            HarfHarfYaz("Beni böyle üzebilirsin", 100);
            Thread.Sleep(2500);
            HarfHarfYaz("Sanki her şeyi denedin", 100);
            Thread.Sleep(3500);
            HarfHarfYaz("Kalabilirsin, pekala gidebilirsin", 100);
            Thread.Sleep(2000);
            HarfHarfYaz("Daha degersiz hissettiremezdin", 100);
            Thread.Sleep(3400);
            HarfHarfYaz("Çünkü ben ne zaman bir şey istesem", 300);
            Thread.Sleep(1400);
            HarfHarfYaz("Bana verilen koca bir saçmalık", 100);
            Thread.Sleep(2200);
            HarfHarfYaz("Bilirsem hata nerede bilirsem", 150);
            Thread.Sleep(2200);
            HarfHarfYaz("Hiç şaşırmam kafamı şişirmem", 100);
            Console.WriteLine(); 
        }

        //void geri donussuz
        //hiz=her harfte ne kadar bekleyecek
        static void HarfHarfYaz(string metin, int hiz = 50)
        {
            foreach (char harf in metin)
            {
                Console.Write(harf);
                Thread.Sleep(hiz);
            }
            Console.WriteLine();

        }

    }
}
