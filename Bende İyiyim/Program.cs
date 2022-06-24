using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bende_İyiyim
{
    //Kullanıcıya bugun nasılsın diye sorun
    //Kullanıcı iyiyim derse bende iyiyim kötüyüm derse bende kötüyüm diye cevap verin
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba !");//Bir satır aşağıya atlar
            Console.Write("Bugun nasılsın ?");
            string hal = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ben de "+hal);
            
            Console.ReadLine();
        }
    }
}
