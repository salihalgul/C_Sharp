using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_22_Tas_Kagıt_Makas
{
    class Program
    {
        static void Main(string[] args)
        {
            TasKagitMakas();
            Console.ReadLine();
        }

        private static void TasKagitMakas()
        {
            //Taş makası kırar
            //Kağıt taşı kaplar
            //Makas kağıdı keser

            //Kullanıcının taş/kağıt/makas olarak seçenek girdiği 
            //PC'ın rastgele birini şeçtiği
            //Sonunda skorların tutulduğu 

            //Kullanıcı q ile oyundan çıkabilsin
            int kazanan = 0;
            int kaybeden = 0;
            string kullanici = "";
            do
            {
                Console.WriteLine("Lütfen taş kağıt ve makasa seçeneklerinden birini girin");
                kullanici = Console.ReadLine();
                string[] secenek = { "tas", "kagit", "makas" };
                Random pc = new Random();
                int a = pc.Next(3);//0 1 2

                if(kullanici =="tas" && secenek[a] =="kagit")
                {
                    kaybeden++;
                }
                if (kullanici == "tas" && secenek[a] == "makas")
                {
                    kazanan++;
                }
                if (kullanici == "makas" && secenek[a] == "kagit")
                {
                    kazanan++;
                }
                if (kullanici == "makas" && secenek[a] == "tas")
                {
                    kaybeden++;
                }
                if (kullanici == "kagit" && secenek[a] == "tas")
                {
                    kazanan++;
                }
                if (kullanici == "kagit" && secenek[a] == "makas")
                {
                    kaybeden++;
                }

                Console.WriteLine("Kullanıcı pc yi " + kazanan + " kadar yener");
                Console.WriteLine("Kullanıcı pc ye " + kaybeden + " kadar yenilir");



            } while (kullanici != "q");

        }
    }
}
