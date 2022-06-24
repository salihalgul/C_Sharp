using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_Ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek4();
            Console.ReadLine();
        }

        private static void Ornek4()
        {
            //Kullanıcıdan bir sayı isteyin
            //Sayının faktoriyelini ekrana yazdırın

            Console.WriteLine("Lutfen bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;
            for (int i =1; i <=sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.WriteLine("Faktoriyel değeri "+faktoriyel);
        }
    }
}
