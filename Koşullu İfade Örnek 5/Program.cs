using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koşullu_İfade_Örnek_5
{
    class Program
    {
        //Kullanıcıya 3 tane soru soralım
        //Bilinen soru sayısı :2 
        //Yanlış sayısı :1

        //Türkiye'nin başkenti?
        //Almanya hangi kıtada?
        //Renkleri siyah beyaz olan takım
        static void Main(string[] args)
        {
            Ornek5();
            Console.ReadLine();
        }

        private static void Ornek5()
        {
            int dogru = 0;
            int yanlıs = 0;
            Console.WriteLine("Türkiye'nin başkenti neresidir?");
            string cevap = Console.ReadLine();
            if(cevap=="Ankara" || cevap=="ANKARA")
            {
                dogru++;
            }
            else
            {
                yanlıs++;
            }
            Console.WriteLine("Almanya hangi kıtadadır?");
            string cevab = Console.ReadLine();
            if(cevab=="Avrupa")
            {
                dogru++;
            }
            else
            {
                yanlıs++;
            }
            Console.WriteLine("Renkleri siyah beyaz olan takım nedir?");
            string cevabım = Console.ReadLine();
            if(cevabım=="Beşiktaş")
            {
                dogru++;
            }
            else
            {
                yanlıs++;
            }
            Console.WriteLine("Doğru sayısı " + dogru);
            Console.WriteLine("Yanlış sayısı " + yanlıs);
        }
    }
}
