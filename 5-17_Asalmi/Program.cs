using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_17_Asalmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Asalmi();
            Console.ReadLine();
            
        }

        private static void Asalmi()
        {
            //Kullanıcının girdiği bir sayının asal olup olmadığını ekrana yazdıralım.
            //1 ve kendisi dışında hiçbir sayıya bölünmemesi lazım

            Console.WriteLine("Lutfen bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool asalmi = true;
            if(sayi==1 || sayi==0)
            {
                throw new Exception("Başka sayı girmeliydiniz");
            }
            for (int i = 2; i <sayi; i++)
            {
                if(sayi%i==0)
                {
                    asalmi = false;
                }
            }

            if(asalmi)
            {
                Console.WriteLine("Asal");
            }
            else
            {
                Console.WriteLine("Asal Değil");
            }
        }
    }
}
