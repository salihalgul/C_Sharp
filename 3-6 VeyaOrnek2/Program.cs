using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_VeyaOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PC: Ayın kaçında doğdunuz?
            //K: ....
            //PC: Hangi ayda doğdunuz?
            //K: ....
            //Malesef ikizler burcusunuz:(
            //Yaşasın ikizler değilsiniz

            //22 Mayıs -22 Haziran
            VeyaOrnek2();
            Console.ReadLine();
        }

        private static void VeyaOrnek2()
        {
            Console.WriteLine("Ayın kaçında doğdunuz?");
            int gun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi ayda doğdunuz?");
            string ay = Console.ReadLine();
            if((ay=="Mayis" && gun>=22) || (ay=="Haziran" && gun<=22))
            {
                Console.WriteLine("Malesef ikizler burcusunuz");
            }
            else
            {
                Console.WriteLine("Yaşasın ikizler değilsiniz");
            }
        }
    }
}
