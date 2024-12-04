using System;

namespace Progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7, 2, -4, 5, 12, 1 };

            //Párosak kiválogatása - 1

            //Maximum kiválasztás - 2
            int i, max = 0, maxi = 0;
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
            Console.ReadLine();
        }
    }
}
