using System;

namespace M02Ex017
{
    class Program
    {
        public static void Main(string[] args)
        {
            int bas;
            int pot;
            Console.Write("What's the base: ");
            int.TryParse(Console.ReadLine(), out bas);
            Console.Write("What's the power: ");
            int.TryParse(Console.ReadLine(), out pot);

            double res  =  Math.Pow(bas, pot);

            Console.WriteLine($"O resultado de {bas} elevado a {pot} é igual a {res}");
        }
    }
}