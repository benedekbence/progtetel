using System;

namespace Progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7, 2, -4, 5, 12, 1 };

            //Párosak kiválogatása - 1
            int[] parosok = new int[100];
            int db = 0;
            int i;
            for ( i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    parosok[db] = x[i];
                    db++;
                }
            }
            for ( i = 0; i < db; i++)
            {
                Console.Write(parosok[i] + " ");
            }
            Console.WriteLine();
            //Maximum kiválasztás - 2
            int max = 0, maxi = 0;
            int n = x.Length;
            for (i = 0; i < n; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                    maxi = i;
                }
            }
            Console.WriteLine(max + ", indexe: " + (maxi + 1));
            Console.ReadKey();
        }
    }
}
