using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_14_Metodlarda_Return
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ornekmetod();

            /*string oku = Program.Degeroku();
            Console.WriteLine(oku);*/
            int can = sayiiste();
            Console.WriteLine(can);
            Console.ReadLine();
        }

        private static int sayiiste()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static string Degeroku()
        {
            return Console.ReadLine();
        }

        private static void Ornekmetod()
        {
            Console.WriteLine("Hello");
        }
    }
}
