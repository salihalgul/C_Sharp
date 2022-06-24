using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWhile();
            Console.ReadLine();
        }

        private static void DoWhile()
        {
            int sayi = 0;
            do
            {
                Console.WriteLine("Lutfen bir sayi giriniz");
                int sayiyeni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
                sayi++;
            } while (sayi < 5);
        }
    }
}
