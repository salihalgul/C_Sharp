using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7_Inlıne_İf
{
    class Program
    {
        static void Main(string[] args)
        {
            InLineif();
            Console.ReadLine();
        }

        private static void InLineif()
        {
            //if else if else if else 
            int sayi = 9;
            bool _3unkatimi = 9 % 3 == 0 ? true : false;
            string kullanici_sehir = Console.ReadLine();
            string sehir = kullanici_sehir == "Istanbul" ? "34" : kullanici_sehir == "istanbul" ? "34" : "0";
            Console.WriteLine(sehir);
        }
    }
}
