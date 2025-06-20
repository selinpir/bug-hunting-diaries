using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//bir uygulama bir ya da birden fazla sınıftan olusabilir. ancak sadece bir baslangıc noktası olmalıdır.
//büyük küçük harf duyralıdır !!!
//sınıf: bir nesnenin şeklini tanımlayan bir şablondur. yazılacak kodun kapsama alanı denebilir. 
//her bir sınıf bir .cs dosyası icerir.
//using deyimi, önceden tanımlı sınıfların adresini belirtir.

namespace konsol1 
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //main:baslangic metodudur. uyg calismaya buradan baslar
            //console.writeline(""); ekrana yazdırma
            //console.read();

            //Console.WriteLine("merhaba, hava cok sicak");
            //Console.Read();
            Ilksinifim.EkranaYaziYaz();
        }
    }
    
    class Ilksinifim
    {
        public static void EkranaYaziYaz()
        {
            Console.WriteLine("merhaba bu icinden cagirma");
        }
    }
}
