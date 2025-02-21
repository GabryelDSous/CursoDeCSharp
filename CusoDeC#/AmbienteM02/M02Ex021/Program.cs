using System;

namespace M02Ex021
{
    class Program
    {
        public static void Main(string[] args)
        {
            float num = 0;
            Console.Write("Digite um número real: ");
            float.TryParse(Console.ReadLine(), out num);

            Console.WriteLine($"Analisando o número {num}");
            Console.WriteLine($"Usando Floor() = {Math.Floor(num)}");
            Console.WriteLine($"Usando Ceiling() = {Math.Ceiling(num)}");
            Console.WriteLine($"Usando Round() = {Math.Round(num)}");
            Console.WriteLine($"Usando Truncate() = {Math.Truncate(num)}");
        }
    }
}