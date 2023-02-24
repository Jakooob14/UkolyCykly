using System;

namespace HowManyNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers separated by a comma and I will count how many there are:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int howMany = input == "" ? 0 : numbers.Length;
            
            Console.WriteLine($"There are {howMany} numbers");
        }
    }
}