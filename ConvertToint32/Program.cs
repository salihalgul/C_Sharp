using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToint32
{
    class Program
    {
        //Convert sınıfının Toint32 metoduna "78" parametresini gönderin
        //Bu ifadeyi bir değişkene atayın
        //Değişkeni ekrana yazdıralım.
        static void Main(string[] args)
        {
            string can = "78";
            int cevrim = Convert.ToInt32(can);
            Console.WriteLine(cevrim);
            Console.ReadLine();
        }
    }
}
