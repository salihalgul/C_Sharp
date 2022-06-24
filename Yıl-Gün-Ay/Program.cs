using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yıl_Gün_Ay
{
    class Program
    {
        //DateTime sınıfının Today elemanının Year elemanını bir değişkene atayalım
        //DateTime sınıfının Today elemanının Month elemanını bir değişkene atayalım
        //DateTime sınıfının Today elemanının Day elemanını bir değişkene atayalım.
        //Yarının tarihini ekrana yazdırın
        //28.11.2018
        static void Main(string[] args)
        {
            int yıl = DateTime.Today.Year;
            int ay = DateTime.Today.Month;
            int gün = DateTime.Today.Day+1;
            Console.WriteLine(gün + "." + ay + "." + yıl);
            Console.ReadLine();

        }
    }
}
