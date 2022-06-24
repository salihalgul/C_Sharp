using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koşullu_İfade_Örnek_3
{
    class Program
    {
        //PC: Hangi programlama dilini seviyorsun
        //K : .....
        //Aldığımız cevaba göre;
        //C# olarak cevap gelirse "Harika!"
        //PHP olarak cevap gelirse "Güzelmiş"
        //Farklı bir değer gelirse "Ama C# da güzel."
        static void Main(string[] args)
        {
            Ornek3();
            Console.ReadLine();
        }

        private static void Ornek3()
        {
            Console.WriteLine("Hangi programlama dilinin seviyorsun ?");
            string cevap = Console.ReadLine();
            if(cevap == "c#" || cevap =="C#")
            {
                Console.WriteLine("Harika!");
            }
            else if(cevap=="php" || cevap=="PHP")
            {
                Console.WriteLine("Güzelmiş");
            }
            else
            {
                Console.WriteLine("Ama C# da güzel");
            }
        }
    }
}
