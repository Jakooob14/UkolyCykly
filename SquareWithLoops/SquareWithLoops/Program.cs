using System;

namespace SquareWithLoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*  ");
                }

                Console.WriteLine();
            }
        }
    }
}