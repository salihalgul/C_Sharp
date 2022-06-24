using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleCursorsizeBackgroundColor
{
    class Program
    {
        //Console sınıfının Title elemanını değiştirin 
        //Console sınıfının CursorSize elemanını değiştirin 
        //Console sınıfının BackgroundColor elemanını değiştirin
        static void Main(string[] args)
        {
            Console.Title = "Can";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.CursorSize = 60;
            Console.CursorLeft = 30;
            Console.CursorTop = 30;
            Console.WriteLine("Deneme");
            Console.ReadLine();
        }
    }
}
