using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koşullu_İfade_Örnek_2
{
    class Program
    {
        //Kullanıcıdan yaşını isteyelim
        //Aldığımız cevaba göre;
        //Eğer kişi reşitse: "Ehliyet alabilirsiniz."
        //Reşit değilse : "Ehliyet alamazsınız"

        static void Main(string[] args)
        {
            Ornek2();
            Console.ReadLine();
        }

        private static void Ornek2()
        {
            Console.WriteLine("Kaç yaşındasınız?");
            int yas = Convert.ToInt32(Console.ReadLine());
            if(yas>=18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz");
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız");
            }
        }
    }
}
