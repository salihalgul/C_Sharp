using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek2();
            Console.ReadLine();
        }

        private static void Ornek2()
        {
            //int[] sayidizi = {19,45,-247,212,-134,319,-78}
            //Dizideki en büyük negatif sayıyı ekrana yazdırın
            //Dizideki en küçük pozitif sayıyı ekrana yazdırın
            int[] sayidizi = { 19, 45, -247, 212, -134, 319, -78 };
            int kp = int.MaxValue;
            int bn = int.MinValue;
            foreach (var item in sayidizi)
            {
                if(item>0 && item<kp)
                {
                    kp = item;
                }
                else if(item<0 && item>bn)
                {
                    bn = item;
                }
            }

            Console.WriteLine("En büyük negatif sayi " + bn);
            Console.WriteLine("En küçük pozitif sayi " + kp);


        }
    }
}
