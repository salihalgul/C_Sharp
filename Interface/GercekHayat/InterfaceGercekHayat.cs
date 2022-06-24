using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayat
{
    interface InterfaceGercekHayat
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
           Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }

    class OracleServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    class MysqlServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }
    }

    class CustomerManager
    {
        public void Add(InterfaceGercekHayat can)
        {
            can.Add();
        }
    }
}
