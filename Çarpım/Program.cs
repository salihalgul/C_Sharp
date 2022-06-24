using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çarpım
{
    class Program
    {
        //Kullanıcıdan 1-5 arası bir sayı isteyelim.
        //Math sınıfının PI elemanını bir değişkene atayalım.
        //(not:küsüratsız)
        //İki değeri çarpıp ekrana yazdıralım.
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen 1 ile 5 arasında bir değer giriniz");
            int girilen = Convert.ToInt32(Console.ReadLine());
            double can = Math.PI;
            int kusursuz = Convert.ToInt32(can);
            Console.WriteLine(kusursuz * girilen);
            Console.ReadLine();
        }
    }
}
