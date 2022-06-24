using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_21_Rastgele_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            RastgeleDeger();
            Console.ReadLine();
        }

        private static void RastgeleDeger()
        {
            string[] sehir = { "İstanbul", "Ankara", "Karabük" };
            //Rastgele bir şehri ekrana yazdırın.
            Random r = new Random();
            int rastgele = r.Next(3);//Max deger gelmez.Yani gelebilecek sayilar 0 1 2 dir
            Console.WriteLine(sehir[rastgele]);

        }
    }
}
