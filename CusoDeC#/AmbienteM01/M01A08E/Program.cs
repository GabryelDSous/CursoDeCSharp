﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out n);
            int d = n * 2;
            Console.WriteLine($"O dobro de {n} é {d}");
        }
    }
}
