using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_Tarihformat
{
    class Program
    {
        static void Main(string[] args)
        {
            TarihFormat();
            Console.ReadLine();
        }
        private static void TarihFormat()
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToShortDateString());
            Console.WriteLine(simdi.ToLongDateString());
            Console.WriteLine(simdi.ToShortTimeString());
            Console.WriteLine(simdi.ToLongTimeString());

            //MM ay (sayı)
            //MMMM ay(yazı)
            //dd gün
            //yyyy yıl
            //hh saat (12 saat)
            //HH saat (24 saat)
            Console.WriteLine(simdi.ToString("MM/dd/yyyy MMMM dd - can hh:mm HH:mm"));

        }
    }
}
