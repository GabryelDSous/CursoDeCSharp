using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A11A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.Write("Hoje é dia ");
            Thread.Sleep(2000);
            Console.Write(dia);

            Console.Write(" do mês ");
            Thread.Sleep(2000);
            Console.Write(mes);

            Console.Write(" do ano ");
            Thread.Sleep(2000);
            Console.Write(ano);
            Thread.Sleep(2000);

            Console.ReadKey();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
