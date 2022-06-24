using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_InlineIf_Örnek
{
    class Program
    {
        //Kullanıcıdan ayrı ayrı 2 sayı isteyelim.
        //1. sayı 2. sayıdan büyük/küçük/eşit
        static void Main(string[] args)
        {
            InLINEIFOrnek();
            Console.ReadLine();
           
        }

        private static void InLINEIFOrnek()
        {
            Console.WriteLine("Ilk sayiyi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string cevap = sayi1 > sayi2 ? "İlk sayi ikincisinden büyüktür" : sayi1 == sayi2 ? "İki sayi eşittir" : "İkinci sayi ilk sayidan büyüktür";
            Console.WriteLine(cevap);
        }
    }
}
