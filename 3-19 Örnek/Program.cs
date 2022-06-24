using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_18_Örnek
{
    class Program
    {

        //Kullanıcının yaşının rakamları toplamı çiftse sayfanın rengi mavi olsun
        //Kullanıcı reşitse sayfanın rengi mavi olsun
        //Diğer durumlarda sayfanın rengi kırmızı olsun
        static void Main(string[] args)
        {
            /* int can = yıl();
             Console.WriteLine(can);*/

            //bool resit = resitMi()

            int a=rakamlar();
            Console.WriteLine("Rakamlar toplamı " + a + " kadardır");
            sayfarengi();
            Console.ReadLine();
        }

        private static void sayfarengi()
        {
            if(rakamlar()%2==0 || resitMi())
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
        }

        private static int rakamlar()
        {
            int yaslar = yasibul();
            int a = yaslar / 10;
            int b = yaslar % 10;
            return a + b;

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
