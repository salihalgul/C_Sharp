using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_Örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek2();
            Console.ReadLine();
        }

        private static void Ornek2()
        {
            //02.01.1980
            //Kullanıcıdan doğum tarihini alalım 
            //Doğduğu günün haftanın hangi günü olduğu 
            //Şimdiye kadar toplam kaç gün yaşamış 

            Console.WriteLine("Lutfen doğum tarihinizi giriniz");
            DateTime dogum = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(dogum.DayOfWeek);
            int gun = (int)(DateTime.Today - dogum).TotalDays;
            Console.WriteLine(gun);
            int yıl = gun / 365;
            Console.WriteLine(yıl);


        }
    }
}
