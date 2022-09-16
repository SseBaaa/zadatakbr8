using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakbr8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetak1 = 0;
            int pocetak2 = 1;
            int retultat = 0;
            Console.WriteLine("Upisi broj");
            int broj = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < broj; i++)
            {
                retultat = pocetak1 + pocetak2;
                pocetak1 = pocetak2;
                pocetak2 = retultat;
            }
            Console.WriteLine(retultat);
            Console.ReadKey();
        }
    }
}
