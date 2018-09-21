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
            int bekertSzam;
            
            //Darab bekérése
            Console.WriteLine("Kérem adja meg hány számot akar megadni: ");
            int bekertDb = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[bekertDb];

            //Tömb feltöltése
            for (int i = 0; i < bekertDb; i++)
            {
                Console.WriteLine("Kérem adja meg a {0}. számot: ",i+1);
                bekertSzam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = bekertSzam;
            }

            //Tömb kiiratása
            Console.WriteLine("Bekért számok: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ", ");
            }

            //Maximum keresése
            int max = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: " + max);

            //Minimum keresése
            int min = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine("A legkisebb szám: " + min);

            Console.ReadLine();

        }
    }
}
