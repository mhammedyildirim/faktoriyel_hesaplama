using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriyeli hesaplancak sayiyi giriniz:  ");
            int sayi = (Convert.ToInt32(Console.ReadLine()));
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.Write("Faktoriyel : {0} ", faktoriyel);

            Console.ReadKey();
        }
    }
}
