using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_Hataları_Fırlatma
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek2();
            //Bu örnekte hata fırlatıcaz
            //PC : Aklından 1-3 arası bir sayı tut
            //K :.....
        }

        private static void Ornek2()
        {
            Console.WriteLine("Aklından 1 ile 3 arasında bir deger tut");
            string sayi = Console.ReadLine();
            switch(sayi)
            {
                case "1":
                    throw new Exception("Beğenmedim");
                    break;
                case "2":
                    throw new Exception("Başka sayı bulamadın mı?");
                    break;
                case "3":

                    throw new Exception("Böyle sayı mı olur çalışmıyorum");
                    break;

            }

        }
    }
}
