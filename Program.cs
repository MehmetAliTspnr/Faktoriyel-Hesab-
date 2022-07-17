using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel_Örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, faktor, deger;
            faktor = 1;
            Console.WriteLine("Faktoriyel Alinacak Sayiyi Giriniz:");
            deger = Convert.ToInt32(Console.ReadLine());
           
            while(deger>1)
            {

                faktor = faktor * deger;
                deger--;

            }
            Console.WriteLine(faktor);

            Console.Read();
        }
    }
}
