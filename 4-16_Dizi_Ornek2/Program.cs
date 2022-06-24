using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_Dizi_Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proje dosyasında kaç tane dosya olduğunu yazdırın
            //İlk Dosyanın yolunu yazdırın
            //Dosya yolundaki son \ daki dosya ismini yazdırın
            Diziornek2();
            Console.ReadLine();
        }

        private static void Diziornek2()
        {
            string[] dosyalar = Directory.GetFiles(@"C:\Users\Can\Desktop\4-16_Dizi_Ornek2\4-16_Dizi_Ornek2");
            Console.WriteLine("C sürücüsünde " + dosyalar.Length + " dosya var");
            Console.WriteLine("İlk dosya");
            Console.WriteLine(dosyalar[0]);
            string[] dosyaadlar = dosyalar[0].Split('\\');
            Console.WriteLine(dosyaadlar[dosyaadlar.Length - 1]);
        }
    }
}
