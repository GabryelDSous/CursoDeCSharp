using System;

namespace M02Ex017
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1 = 8;
            int n2 = 10;
            Console.WriteLine($"O maior valor entre {n1} e {n2} é {Math.Max(n1,n2)}");
            Console.WriteLine($"O menor valor entre {n1} e {n2} é {Math.Min(n1, n2)}");
        }
    }
}