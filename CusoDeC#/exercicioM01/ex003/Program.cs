using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Digite um número Real: ");
            float numReal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Você digitou o valor {numReal:c3}");
            Console.WriteLine($"A parte inteira do número é {Math.Floor(numReal)}");
            Console.WriteLine($"Arredondando, temos o número {Math.Round(numReal)}");
            */
            Console.Write("Informe um nome: ");
            string a = Console.ReadLine().Trim();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
