using System;

namespace M02Ex22
{
    class Program
    {
        static void Main(string[] args)
        { 
            int a = 5, b = 3, c = 8, d = 4;
            // e1
            int e1 = +a + b * 4 - c;
            // e2
            int e2 = (a + b) / d << 2;
            // e3 
            bool e3 = c - b++ != --d + b % 2;
            Console.WriteLine($"A variável e1 = {e1}");
            Console.WriteLine($"A variável e2 = {e2}");
            Console.WriteLine($"A variável e3 = {e3}");
        }
    }
}