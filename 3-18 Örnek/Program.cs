using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_18_Örnek
{
    class Program
    {

        //Kullanıcının yaşının rakamları toplamını ekrana yazdıran bir metod yazalım.
        static void Main(string[] args)
        {
            /* int can = yıl();
             Console.WriteLine(can);*/
           
            //bool resit = resitMi()
            
            rakamlar();
            Console.ReadLine();
        }

        private static void rakamlar()
        {
            int yaslar = yasibul();
            int a = yaslar / 10;
            int b = yaslar % 10;
            Console.WriteLine("Yasim " + yaslar + " dır");
            Console.WriteLine("Yaşlar toplamı " + (a + b) + " kadardır");

        }

        private static bool resitMi()
        {
            return yasibul() >= 18;
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
