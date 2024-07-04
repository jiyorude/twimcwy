using System;
using System.Threading;

namespace twimcwy.Utils
{
    public static class StringUtils
    {
        public static void iterate(string str, int delay = 25)
        {
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public static void wait(int delay = 1000)
        {
            Thread.Sleep(delay);
            Console.WriteLine();
        }
    }
}