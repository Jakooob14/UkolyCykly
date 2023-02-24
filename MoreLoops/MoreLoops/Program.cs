using System;

namespace MoreLoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 40 || i == 60)
                {
                    continue;
                }
                Console.Write(i + ", ");
            }
        }
    }
}