using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Örnek
{
    class Program
    {
        //PC: Kaç yaşındasın ?
        //K: ...
        //PC:Reşit :(true/false)
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç yaşındasın ?");
            int can = Convert.ToInt32(Console.ReadLine());
            bool resit = can >= 18;
            Console.WriteLine(resit);
            Console.ReadLine();
        }
    }
}
