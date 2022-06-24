using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachDongusu();
            Console.ReadLine();
        }

        private static void ForeachDongusu()
        {
            //Dolaşmak istediğimiz dögüyü bunun içine yazıyorsunuz
            string[] ulkeler = { "Türkiye", "Almanya", "Fransa" };
            foreach (var item in ulkeler)
            {
                Console.WriteLine(item);
            }
            int[] can = { 1, 2, 3, 4, 9, 87, 75 };
            foreach (var item in can)
            {
                Console.WriteLine(item);
            }

        }
    }
}
