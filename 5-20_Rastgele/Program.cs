using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_20_Rastgele
{
    class Program
    {
        static void Main(string[] args)
        {
            RastgeleSayi();
            Console.ReadLine();
        }

        private static void RastgeleSayi()
        {
            Random r = new Random();
            int sayi = r.Next(10);//0 ila 9 arasında herhangi bir değer yaratır.
            Console.WriteLine(sayi);
        }
    }
}
