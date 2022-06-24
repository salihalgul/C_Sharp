using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_Veya
{
    class Program
    {
        static void Main(string[] args)
        {
            Veya();
            Console.ReadLine();
        }

        private static void Veya()
        {
            //Veya OR | ||
            //kOŞUllardan herhangi birinin true olması yeterli

            if(false || false)
            {
                Console.WriteLine("Bu kod çalışır");
            }
        }
    }
}
