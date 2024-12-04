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
            //Maximum kiválasztás - 2
            //int n = x.Length;
            //int maxe = x[0];
            //for (int i = 0; i < n; i++)
            //{
            //    if (x[i] > maxe)
            //    {
            //        maxe = x[i];
            //    }
            //}
            //Console.WriteLine(maxe);
            //Console.ReadKey();
        }
    }
}
