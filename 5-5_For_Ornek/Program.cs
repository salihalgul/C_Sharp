using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_For_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            _5_5_For_Ornek();
            Console.ReadLine();
        }

        private static void _5_5_For_Ornek()
        {
            //5 adet ismi tutan bir dizi tanımlayın.Tutulan isimleri giriniz
            //Dizideki isimleri ekrana bastırın

            string[] isimler = { "Can", "Osman", "Tuba", "Cansu", "Meral" };
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write(isimler[i]+"\t");
            }
        }
    }
}
