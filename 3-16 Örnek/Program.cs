using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_16_Örnek
{
    class Program
    {
        //Kullanıcıya doğduğu yılı sorup yılı geri taşıyan bir metod yazın
        //Az önceki metodu kullanarak kullanıcının yaşını hesaplayıp geri taşıyan bir metod yazın.
        static void Main(string[] args)
        {
            /* int can = yıl();
             Console.WriteLine(can);*/
            int yasim = yasibul();
            Console.WriteLine("Yasim " + yasim + " dır");
            Console.ReadLine();
        }

        private static int yasibul()
        {
            return DateTime.Today.Year - yıl();
        }

        private static int yıl()
        {
            Console.WriteLine("Lutfen doğdunuz yılı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
