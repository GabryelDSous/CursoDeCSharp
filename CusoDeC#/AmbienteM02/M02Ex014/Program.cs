using System;

namespace M02Ex014
{
    class Program
    {
        static void Main(string[] args)
            // ++n1; // mesma coisa que n1 = n1 + 1;
            // --n2; // mesma coisa que n2 = n2 + 1
        {
            int n1 = 6;
            int n2 = 9;

            // int n3 = ++n1 + n2--;
            int n3 = n1++ + --n2;

            Console.WriteLine($"n1 vale {n1}, n2 vale {n2} e n3 vale {n3}");
            // 7 8 16
            // 7 8 14
            int x = 9;
            Console.WriteLine($"O valor de x é {x++}");
            Console.WriteLine($"No final, x vale {x}");
            Console.ReadKey();
        }
    }
}