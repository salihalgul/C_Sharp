using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
           // Assss();
            Dictionary<string,string> can=new Dictionary<string, string>();
            can.Add("book","kitap");
            can.Add("table","masa");
            can.Add("computer","bilgisayar");

           // Console.WriteLine(can["book"]);

           /* foreach (var herhangi in can)
            {
                Console.WriteLine(herhangi.Value);
            }*/
            Console.WriteLine(can.ContainsKey("book"));
            Console.WriteLine(can.ContainsValue("computer"));
            Console.ReadLine();
        }

        private static void Assss()
        {
/*ArrayList sehirler=new ArrayList();
            sehirler.Add("Mersin");
            sehirler.Add("Adana");
            sehirler.Add(1);


            foreach (var hobaa in sehirler)
            {
                Console.WriteLine(hobaa);
            }*/

            /* List<string> cities =new List<string>();
            cities.Add("Ankara");
            cities.Add("iSTANBUL");

            foreach (var can in cities)
            {
                Console.WriteLine(can);
            }*/

            List<Customer> canan = new List<Customer>
            {
                new Customer {Id = 1, Firstname = "Can"},
                new Customer {Id = 3, Firstname = "Hasan"}
            };
            var customer2 = new Customer()
            {
                Id = 5,
                Firstname = "Ossman"
            };
            canan.Add(customer2);
            canan.AddRange(new Customer[2]
            {
                new Customer {Id = 8, Firstname = "Hakkan"},
                new Customer {Id = 15, Firstname = "Gülnaz"}
            });

            Console.WriteLine(canan.Contains(customer2));

            /*foreach (var herhangi in canan)
            {
                Console.WriteLine(herhangi.Id);
            }*/
            canan.Remove(customer2);
            canan.Insert(0, customer2);
            var index = canan.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            var count = canan.Count;
            Console.WriteLine("Count : {0}", count);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }

    }
}
