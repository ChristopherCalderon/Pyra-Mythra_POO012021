using System;

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0,b = 0;

            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Substracting {a} + {b} equals {subsNumbers(a,b)}");
        }

        public static int subsNumbers(int a, int b)
        {
            return a-b;
        }
    }
}
