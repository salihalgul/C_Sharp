using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bip_Sesi
{
    class Program
    {
        //Kullanıcıya kaç yaşında olduğunu sorun
        //En güzel yaşın kullanıcının yaşı olduğunu bastırın
        //Bip sesiyle programı sonlandırın
        static void Main(string[] args)
        {
            Console.Write("Kaç yaşındasınız ?");
            var yas = Console.ReadLine();
            Console.WriteLine("En guzel yas " + yas);
            Console.ReadLine();
            Console.Beep();
           
            
        }
    }
}
