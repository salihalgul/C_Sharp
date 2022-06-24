using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluImplemantasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] can = new IWorker[3]
            {
                new Worker(), 
                new Manager(), 
                new Robot()
            };

            foreach (var hopbara in can)
            {
                hopbara.Work();
            }

            IEat[] canan = new IEat[2]
            {
                new Manager(), 
                new Worker()
            };

            foreach (var herhangi in canan)
            {
                herhangi.Eat();
            }

            ISalary[] dizi = new ISalary[2]
            {
                new Manager(), 
                new Worker()
            };

            foreach (var das in dizi)
            {
                das.GetSalary();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
       
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çok yedin");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çok paramı istiyosun");
        }

        public void Work()
        {
            Console.WriteLine("Çok çalıştın bravo");
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çok yedin");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çok paramı istiyosun");
        }

        public void Work()
        {
            Console.WriteLine("Çok çalıştın bravo");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çok çalıştın bravo");
        }
    }
}
