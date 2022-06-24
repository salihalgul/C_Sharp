using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            Console.ReadLine();            
        }

        private static void Ornek1()
        {
            //int[] a={14,55,-19,22,-134,39,-81};
            //Kullanıcıdan bir sayı girmesini isteyin
            //Girilen sayının bu dizide var olup olmadığını ekrana yazdırın
            //do while ve foreach için ayrı ayrı soru çözümünü yapın

            /*int[] a = { 14, 55, -19, 22, -134, 39, -81 };
            int sayac = 0;

            do
            {
                sayac++;
                Console.WriteLine("Lutfen bir sayi degeri giriniz");
                int deger = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a.Length; i++)
                {
                    if (deger == a[i])
                    {
                        Console.WriteLine("Dizide " + deger + " elamanı bulunur");
                    }
                }
                
            } while (sayac != 7);*/
            int[] a = { 14, 55, -19, 22, -134, 39, -81 };
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool buldukMu = false;

            foreach (var item in a)
            {
                if (!buldukMu = true)
                    buldukMu = sayi = item;
            }
            if(buldukMu)
            {
                Console.WriteLine("Dizide var");

            }
            else
            {
                Console.WriteLine("Dizide yok");

            }

        }
    }
}
