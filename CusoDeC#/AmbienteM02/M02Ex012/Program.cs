﻿using System;

namespace M02Ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 8;
            int c = 2;

            b = a = c = 9;

            Console.WriteLine($"{a} {b} {c}");
            Console.ReadKey();
        }
    }
}