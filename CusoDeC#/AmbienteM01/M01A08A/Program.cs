﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito prazer em te conhecer, "+ nome +"!!");
            Console.ReadKey();
        }
    }
}
