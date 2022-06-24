using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FarkliTarih();
            Console.ReadLine();
        }

        private static void FarkliTarih()
        {
            DateTime tarih = Convert.ToDateTime("2019-01-01");//Veritabanında yıl ay gün şeklinde tutulur.
            Console.WriteLine(tarih);
            DateTime mezuniyet = new DateTime(2019, 06, 20);
            Console.WriteLine("Yılın " + mezuniyet.DayOfYear + ". günü");
            Console.WriteLine(mezuniyet.DayOfWeek);
        }
    }
}
