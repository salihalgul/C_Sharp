using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_DiziOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Diziornek3();
            Console.ReadLine();
        }

        private static void Diziornek3()
        {
            string[] sorular = { "33 plakayalı ilimiz?", "Muzu meşhur olan ilçe", "Mersin hangi bölgede?" };
            //Sırasıyla bu soruları soran,cevaplarını değerlendiren,en sonunda doğru yanlış sayısını ekrana yazan uygulamayı yazınız.
            string[] cevap = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sorular[i]);
                cevap[i] = Console.ReadLine();

            }
            int dogru = 0;
            int yanlis = 0;

            if(cevap[0]=="Mersin")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            if(cevap[1]=="Anamur")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            if(cevap[2]=="Akdeniz")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }

            Console.WriteLine("Dogru sayınız " + dogru);
            Console.WriteLine("Yanlıs sayınız " + yanlis);


        }


    }
}
