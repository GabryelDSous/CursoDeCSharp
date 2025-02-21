using System;

namespace M02Ex017
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Square Root Calculator ===");
            int num;
            Console.Write("Number = ");
            int.TryParse(Console.ReadLine(), out num);

            float sqrt = MathF.Sqrt(num);
            float cbrt = MathF .Cbrt(num);

            Console.WriteLine($"The Square Root of {num} is {sqrt:f2}");
            Console.WriteLine($"The Cube Root of {num} is {cbrt:f2}");
        }
    }
}