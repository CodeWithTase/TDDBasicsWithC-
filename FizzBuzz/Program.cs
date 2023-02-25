using FizzBuzz.Library;
using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzy.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}
