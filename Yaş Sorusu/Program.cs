using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaş_Sorusu
{
    class Program
    {
        //PC : Kaç yaşındasın?
        //K :45
        //PC :40 yaşında gösteriyorsunuz
        static void Main(string[] args)
        {
            Console.Write("Kaç yaşındasınız");
            var yas = Console.ReadLine();
            int yasim = Convert.ToInt32(yas);
            yasim = yasim - 5;
            Console.Write(yasim);
            Console.Write(" yasinda gösteriyorsunuz");
            Console.ReadLine();
        }
    }
}
