using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_15_Alfabe
{
    class Program
    {
        static void Main(string[] args)
        {
            alfabe();
            Console.ReadLine();
        }

        private static void alfabe()
        {
            //Alfabeyi ekrana bastırın
            for (int i = 'A'; i <= 'Z'; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
