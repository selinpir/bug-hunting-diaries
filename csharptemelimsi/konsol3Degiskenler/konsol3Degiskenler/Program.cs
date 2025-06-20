using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace konsol3Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEGİSKENLER HAKKİNDA

            //DegiskenIsımleriniDeveHorgucuOlarakYapmakOnerilir
            //int
            //int a = 10;
            //int b = 22;
            //int c = a + b;
            //Console.WriteLine(c);   

            //int IntDegisken = 85;
            //double DoubleDegisken = 2.4;

            //char CharDegisken = 'U';
            //string StringDegisken = "datakod";

            //Console.WriteLine("degisken turlerimiz: sayi {0},ondalik {1},karakter {2},metin {3}", IntDegisken,DoubleDegisken,CharDegisken,StringDegisken);

            //bool BoolDegiskeni = false;
            //DateTime DateTimeDegisken = DateTime.Now;

            //object ve var her degisken türünü tasıyabilir. veri cekilirken hangi veri türü gelecek bilinmedigi durumlarda kullanılır.

            //object olarak tanımlanan değişken her tipteki veriyi içinde saklayablir.
            //Fakat object tipteki değişkene atanan değer Boxing(Kutulama) işlemine uğrar.
            //Yani,object tipiyle oluşturduğumuz bir string değişken, RAM’e string olarak değilde object olarak kaydedilir.

            //object ObjectDegiskeni = "selinos";
            //object ObjectDegiskeni2 = 2;

            //var tipi değişken tanımlarsanız eğer değişkenin tipini siz değil derleyici tanımlayacaktır.
            //Derleyicinin tanımladığı tipe göre o veri RAM üzerin de o tiple saklanacaktır.

            //var VarDegiskeni =19.0;
            //var VarDegiskeni2 = true;

            //-----------------------------------------------------------------------------------------------------

            //BASIC UYGULAMA

            //Console.WriteLine("en sevdiginiz lost karakteri?");
            //string Karakter=Console.ReadLine();

            //PARSE
            //Console.WriteLine("en sevdiginiz lost sezonu?");
            //int Sezon = int.Parse(Console.ReadLine());
            ////ONEMLİ-PARSE!! console.readline hep string dondurur bu yüzden parse etmeliyiz

            //Console.WriteLine("HMM ZEVKLİSİN");

            //Console.WriteLine("ucaginin dusmesini ister miydin ??(evet: true/hayır: false)");
            //bool DogruMu=bool.Parse(Console.ReadLine());

            //-----------------------------------------------------------------------------------------------------
            //CONVERT: veri türü degistirme
            string Sdegisken = "53";
            int Idegisken= Convert.ToInt32(Sdegisken);



            Console.Read();
 




        }
    }
}
