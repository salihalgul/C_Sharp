using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_18_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            ArasındaAsal();
            Console.ReadLine();
        }

        private static void ArasındaAsal()
        {
            //1 50 arasında kaç tane asal sayı var?
            int kactane=0;
            for (int i = 1; i < 50; i++)
            {
                if (IsAsal(i))
                    kactane++;
            }
            Console.WriteLine("1-50 arasında " + kactane + " asal sayı vardır");
        }

        private static bool IsAsal(int sayi)
        {
            bool asalMi = true;
            if (sayi == 1 || sayi == 0)
                return false;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    asalMi = false;
            }
            return asalMi;


        }
    }
}
