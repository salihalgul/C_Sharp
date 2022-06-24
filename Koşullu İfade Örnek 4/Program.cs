using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koşullu_İfade_Örnek_4
{
    class Program
    {
        //PC: Kare mi daire mi ?
        //kare ise "Kenar uzunluğu?"
        //daire ise "Yarıçapı?"

        //İlgili şeklin alanını hesaplayıp ekrana yazdıralım.
        //(kare için: kenar x kenar)
        //(daire için yarıçapın karesi x pi)
        //Math.PI   //Math.Pow()
        static void Main(string[] args)
        {
            Ornek4();
            Console.ReadLine();
        }

        private static void Ornek4()
        {
            Console.WriteLine("Kare mi daire mi?");
            string cevap = Console.ReadLine();
            if(cevap =="kare")
            {
                Console.WriteLine("Kenar uzunluğunu giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else
            {
                Console.WriteLine("Yarıçap uzunluğunu giriniz");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.PI * Math.Pow(r, 2));

            }
        }
    }
}
