using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    //2 Tarih arasındaki süre hesabı
    //Mezuniyet tarihiyle (20.06.2019) bugün arasında kaç gün olduğunu bulunuz
    class Program
    {
        static void Main(string[] args)
        {
            Surehesap();
            Console.ReadLine();
        }

        private static void Surehesap()
        {
            DateTime mezuniyet = new DateTime(2019, 6, 20);
            TimeSpan kalansure = mezuniyet - DateTime.Today;
            Console.WriteLine(kalansure);
            Console.WriteLine(kalansure.TotalDays);
        }
    }
}
