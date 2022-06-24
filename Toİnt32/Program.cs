using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toİnt32
{
    class Program
    {
        //Console sınıfının Readline metodundan dönen değeri 
        //bir değişkene atayın
        //Convert sınıfının Toınt32 metoduna bu değişkeni parametre olarak gönderin
        //Bu ifadeyi başka bir değişkene atayın
        static void Main(string[] args)
        {
            var can = Console.ReadLine();
            int boz = Convert.ToInt32(can);
            Console.WriteLine(boz);
            Console.ReadLine();
        }
    }
}
