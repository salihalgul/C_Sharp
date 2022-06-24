using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_For_Dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            For_Dongusu();
            Console.ReadLine();
        }

        private static void For_Dongusu()
        {
            //Belli sayılar arasında otomatik dolaşmak istersek for döngüsünü kullanıyoruz
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //burdan devam eder
        }
    }
}
