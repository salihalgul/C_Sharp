using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_ÇıkışaNeKadarVar
{
    class Program
    {
        //Şu andan gece 11 e kadar ne kadar süre var
        static void Main(string[] args)
        {
            CikisaNeKadarVar();
            Console.ReadLine(); 
        }

        private static void CikisaNeKadarVar()
        {
            var simdi = DateTime.Now;
           // var cikis = Convert.ToDateTime("2019-12-02 23:00:00");
            var cikisim = new DateTime(2019, 12, 02, 23, 0, 0);
            TimeSpan sure = cikisim - simdi;
            Console.WriteLine("Toplam " + sure.Minutes + " dk");
            Console.WriteLine("Çıkışa " + sure.Hours + " saat" + sure.Minutes + " dk kaldı");
        }
    }
}
