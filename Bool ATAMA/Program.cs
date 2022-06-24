using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_ATAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bir bool değişkene şu ifadeyi atayalım:
             * Directory sınıfının Exists metoduna "test parametresini gönderelim"*/
            bool varMi = Directory.Exists("test");
            Console.ReadLine();
           
        }
    }
}
