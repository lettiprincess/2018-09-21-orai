using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            int bekertSzam;

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérem adja meg a {0}. számot: ",i+1);
                bekertSzam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = bekertSzam;
            }
            Console.WriteLine("Bekért számok: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ", ");
            }

            Console.ReadLine();

        }
    }
}
