using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayat
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager=new CustomerManager();
           // customerManager.Add(new SqlServerCustomerDal());
            InterfaceGercekHayat[] yeni = new InterfaceGercekHayat[3]
            {
                new OracleServerCustomerDal(), 
                new MysqlServerCustomerDal(), 
                new SqlServerCustomerDal()

            };

            foreach (var haydi in yeni)
            {
                haydi.Add();
                haydi.Delete();
                haydi.Update();
            }


            Console.ReadLine();
        }
    }
}
