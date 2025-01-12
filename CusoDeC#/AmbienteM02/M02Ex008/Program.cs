using System;

namespace M02Ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Informe um número: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"O número {num:D} 'que você digitou é {(num%2==0?"PAR":"ÍMPAR")}");
        }
    }
}