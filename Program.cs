using System;

namespace PerfetNumbers
{
    public class PerfectNumbers
    {
        public static void Main()
        {
            int k, l, s ,first, socend;

            Console.Write("Start Number : ");
            first = int.Parse(Console.ReadLine());
            Console.Write("End Number : ");
            socend = int.Parse(Console.ReadLine());

            for (k = first; k <= socend; k++)
            {
                l = 1;
                s = 0;
                while (l < k)
                {
                    if (k % l == 0)
                        s = s + l;
                    l++;
                }
                if (s == k)
                    Console.WriteLine(k + " is perfect number");
            }
        }
    }
}