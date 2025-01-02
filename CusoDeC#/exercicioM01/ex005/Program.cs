using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int anoAtual = DateTime.Now.Year;
            Console.Write("Em que ano você nasceu? ");
            int anoNasc = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Estamos atualmente no anno de {anoAtual}");
            Console.WriteLine($"Se você nasceu em {anoNasc}, vai ter {anoAtual-anoNasc} anos.");

            Console.ReadKey();
        }
    }
}
