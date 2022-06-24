using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_While
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileDongusu();
            Console.ReadLine();
        }

        private static void WhileDongusu()
        {
            /* while(true)
             {
                 Console.WriteLine("Gunaydın");
             }*/

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/
            int sayi = 0;
            while(sayi<5)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
        }
    }
}
