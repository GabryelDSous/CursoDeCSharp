using System;

namespace M02Ex021
{
    class Program
    {
        public static void Main(string[] args)
        {
            float ang = 0;
            Console.Write("Informe um ângulo em Graus: ");
            float.TryParse(Console.ReadLine(), out ang);

            float rad = ang * (MathF.PI / 180);

            Console.WriteLine($"O seno de {ang}° é igual a {MathF.Sin(rad):f3}");
            Console.WriteLine($"O cosseno de {ang}° é igual a {MathF.Cos(rad):f3}");
            Console.WriteLine($"A tangente de {ang}° é igual a {MathF.Tan(rad):f3}");
        }
    }
}