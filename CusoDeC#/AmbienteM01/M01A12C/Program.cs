using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0f;
            Console.Write("Qual é o seu salário? ");
            float.TryParse(Console.ReadLine(), out sal);
            Console.Write($"Você ganha {sal:c} por mês!");
        }
    }
}
