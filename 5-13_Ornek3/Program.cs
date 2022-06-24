using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek3();
            Console.ReadLine();
        }

        private static void Ornek3()
        {
            //Kullanıcının 05321234567 şeklinde girdiği bir telefon numarasını 0532 123 45 67 formatına çevirin
            /* string tlf = "05321234567";
             for (int i = 0; i < tlf.Length; i++)
             {
                 if(i==4 || i==7 || i==9)
                 {
                     Console.Write(" ");
                 }
                 Console.Write(tlf[i]);
             }*/

            string tlf = "05321234567";
            int i = 0;
            foreach (var item in tlf)
            {
                if(i==4 || i==7 || i==9)
                {
                    Console.Write(" ");
                }
                Console.Write(item);
                i++;
            }

        }
    }
}
