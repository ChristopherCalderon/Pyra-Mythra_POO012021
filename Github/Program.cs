﻿using System;

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

            Console.WriteLine($"Adding {a} x {b} equals {multNumbers(a,b)}");
        }

        public static int multNumbers(int a, int b)
        {
            return a*b;
        }
    }
}
