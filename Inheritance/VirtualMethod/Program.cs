using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer can=new SqlServer();
            can.Add();
            Mysql canan=new Mysql();
            canan.Add();
            can.Delete();
            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Eklendi");
        }
        public override void Delete()
        {
            Console.WriteLine("Silindi");
        }

    }

    class Mysql:Database
    {
        
    }
}
