using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            // "29.11.2018 değerini bir string değişkene atayın."
            //degisken.Split('.') bu ifadeyi bir değişkene atayın.
            //Son değişkenin son elemanını ekrana yazdırın
            Diziornek1();
            Console.ReadLine();
        }

        private static void Diziornek1()
        {
            string tarih = "29.11.2018";
            string[] parcalar = tarih.Split('.');
            Console.WriteLine(parcalar[2]);
            int index = parcalar.Length - 3;
            Console.WriteLine(parcalar[index]);
        }
    }
}
