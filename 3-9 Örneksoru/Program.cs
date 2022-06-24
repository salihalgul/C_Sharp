using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_9_Örneksoru
{
    class Program
    {
        //PC:Vize notunuz?
        //K: .....
        //PC:Final Notunuz?
        //K: .....
        //(Vize %40 final %60 geçer not: 50)
        //Geçti/Kaldı
        //float için Converttosingle
        //Vize 0 sa final kaç olursa olsun kalsın
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();
        }

        private static void Ornek()
        {
            Console.WriteLine("Vize notunuzu giriniz ");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz ");
            double final = Convert.ToDouble(Console.ReadLine());
            vize = vize * 0.4;
            final = final * 0.6;
            if(vize ==0)
            {
                Console.WriteLine("Kaldınız");
            }
            else if((vize+final)>=50)
            {
                Console.WriteLine("Sınıfı geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");

            }
        }
    }
}
