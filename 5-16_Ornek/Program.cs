using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_16_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek7();
            Console.ReadLine();
        }

        private static void Ornek7()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
