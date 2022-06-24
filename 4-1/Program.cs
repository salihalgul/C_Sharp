using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        //Pascal Case :Her kelimenin baş harfi büyük
        //Camel Case : buŞekildeYazılır
        //Macar Notasyonu :stryas,dblkonum
        static void Main(string[] args)
        {
            Tarihsaat();
            Console.ReadLine();

        }

        private static void Tarihsaat()
        {
            DateTime bugun = DateTime.Today;
            Console.WriteLine(bugun);
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
        }
    }
}
