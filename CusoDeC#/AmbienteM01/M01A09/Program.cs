﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int n = gerador.Next(1,4);
            Console.WriteLine("Acabei de gerar um número: "+ n);
            
        }
    }
}
