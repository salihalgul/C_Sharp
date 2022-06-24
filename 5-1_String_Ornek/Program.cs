using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_String_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOrnek();
            Console.ReadLine();
        }
        private static void StringOrnek()
        {
            //PC :Aradığınız öğrenci adı soyadı ?
            //K: ....
            //PC: 1-En az 3 karakter girmelisiniz (daha azsa)
            //    2-Boş Bırakmayınız
            //    3-Teşekkürler

            Console.WriteLine("Aradığınız öğrenci adı soyadı?");
            string can = Console.ReadLine();

            if (string.IsNullOrEmpty(can.Trim()))
            {
                Console.WriteLine("Boş burakmayınız");
            }
            else if(can.Length<3)
            {
                Console.WriteLine("En az 3 karakter girmelisin");
            }
            else
            {
                Console.WriteLine("Teşekkürler");
            }
            


        }



    }
}
