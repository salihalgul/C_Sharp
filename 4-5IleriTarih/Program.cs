using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5IleriTarih
{
    class Program
    {
        static void Main(string[] args)
        {
            IleriTarih();
            Console.ReadLine();
        }

        private static void IleriTarih()
        {
            DateTime bugun = DateTime.Today;
            DateTime birAySonra = bugun.AddMonths(1);
            DateTime birAyOnce = bugun.AddMonths(-1);
            DateTime birGunSonrasi = bugun.AddDays(1);
            DateTime birGunOncesi = bugun.AddDays(-1);

            Console.WriteLine("bir ay sonrası : " + birAySonra);
            Console.WriteLine("bir ay öncesi : " + birAyOnce);
            Console.WriteLine("bir gün sonrası : " +birGunSonrasi );
            Console.WriteLine("bir gün öncesi : " +birGunOncesi );


        }
    }
}
