using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)


        {
           for (int i = 0; i < 101; i++) // for loop 0 to 100 increment +1
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}