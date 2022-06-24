using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_Veya_Örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //PC: Kaç yaşındasınız?
            //K: .....
            //0-20 yaş arası için "teşekkürler"
            //20-50 yaş arası için "Çalışıyor musunuz? (e/h)" ->"Tşk."
            //50+ için "Teşekkürler"
            _3_5_Veya_Örnek();
            Console.ReadLine();
        }

        private static void _3_5_Veya_Örnek()
        {
            /*Console.WriteLine("Kaç yaşındasınız");
            int cevap = Convert.ToInt32( Console.ReadLine());
            if(cevap>0 && cevap<=20)
            {
                Console.WriteLine("Teşekkürler");
            }
            else if(cevap>20 && cevap<=50)
            {
                Console.WriteLine("Çalışıyormusun ?");
                string calısan = Console.ReadLine();
                if(calısan=="e" || calısan=="h")
                {
                    Console.WriteLine("TŞK");
                }
            }
            else
            {
                Console.WriteLine("Teşekkürler");
            }*/
            Console.WriteLine("Kaç yaşındasınız");
            int cevap = Convert.ToInt32(Console.ReadLine());
            if(cevap<20 || cevap>50)
            {
                Console.WriteLine("Teşekkürler");
            }
            else
            {
                Console.WriteLine("Çalışıyormusun ?");
                Console.ReadLine();
                Console.WriteLine("TŞK");
            }
        }
    }
}
