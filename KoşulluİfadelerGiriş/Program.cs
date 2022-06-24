using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoşulluİfadelerGiriş
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
            if(true)
            {
                Console.WriteLine("Bu kod her zaman çalışır");
            }
            if(DateTime.Today.Day==28)
            {
                Console.WriteLine("Ayın 28 i geldi inidirim zamanı");
            }
            else if(DateTime.Today.Day ==12)
            {
                Console.WriteLine("Çok az kaldı ! Yarın indirim var");
            }
            else
            {
                Console.WriteLine("İndirim için ayın 13 ünü bekleyin");
            }
        }
    }
}
