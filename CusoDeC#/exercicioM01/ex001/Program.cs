using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10,5);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Meu");
            Thread.Sleep(1000);

            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write("BRASIL");
            System.Threading.Thread.Sleep(1000);

            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.Write("BRASILEIRO");

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
