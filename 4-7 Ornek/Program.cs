using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_Ornek
{
    //10 gün sonrasını gün.ay.yıl formatında yazdırın
    class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            Console.ReadLine();
        }

        private static void Ornek1()
        {
            DateTime simdi = DateTime.Now;
            DateTime ongunsonra = simdi.AddDays(15);
            Console.WriteLine(ongunsonra.ToString("dd.MM.yyyy"));
        }
    }
}
