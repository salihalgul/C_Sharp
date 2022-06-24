using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndirim
{
    class Program
    {
        //PC: Kaç lira alışveriş yaptın?
        //K: 100
        //(%10 indirim olduğunu varsayalım)
        //PC: 10 TL indirim kazandın!
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç lira alışveriş yaptın? ");
            var can = Console.ReadLine();
            int yeni = Convert.ToInt32(can);

            yeni = yeni / 10;

            Console.WriteLine(yeni + " Tl indirim kazandın");
            Console.ReadLine();
        }
    }
}
