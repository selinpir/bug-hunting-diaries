using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace konsol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proporties :nesneye ozellik verir,anahtar sembolundedir
            //Console.Title = "İlk Projem";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            //metotlar: belirli bir görevi yerine getiriler,küp sembolundedirler.
            //Write metodu sadece verilen ifadeyi yazarken, WriteLine aynı zamanda bir satır sonu (newline) karakteri ekler.
            Console.WriteLine("texttexttexttexttext");
            //Console.Write("text2");

            //placeholder
            Console.WriteLine("selin {0} öğrencisi", "ybs");

            Console.Beep(); //ses verir biip


            Console.WriteLine("selinos");
            Console.WriteLine(2002);
            Console.WriteLine(false);
            //Console.ReadLine() konsoldan veri okuduktan sonra bir alt satıra geçer. Console.Read() ise sonraki satıra geçmez.


            Console.Read();
            Console.ReadLine();
        }
    }
}
