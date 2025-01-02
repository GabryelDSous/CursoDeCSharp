using System;

namespace M02Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Denominador: ");
            int.TryParse(Console.ReadLine(), out n2);

            Console.WriteLine($"Divisão inteira {n1} ÷ {n2} = {n1/n2}");
            Console.WriteLine($"Divisão real {n1} ÷ {n2} = {(float)n1/n2:F2}");
            Console.ReadKey();  
        }
    }
}