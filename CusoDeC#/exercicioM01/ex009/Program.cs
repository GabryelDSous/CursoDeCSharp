using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            // Produto 1
            Console.Write("Produto 1: ");
            string prod1 = Console.ReadLine();
            Console.Write("Preço 1: R$");
            float preco1 = Convert.ToSingle(Console.ReadLine());

            // Produto 2
            Console.Write("Produto 2: ");
            string prod2 = Console.ReadLine();
            Console.Write("Preço 2: R$");
            float preco2 = Convert.ToSingle(Console.ReadLine());

            Console.SetCursorPosition(0, 10);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Produto{"Preço",30}");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine($"{prod1,-20}{preco1,17:C}");
            Console.WriteLine($"{prod2,-20}{preco2,17:C}");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
