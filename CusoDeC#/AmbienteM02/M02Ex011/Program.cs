﻿using System;

namespace M02Ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1 = 0;
            int op2 = 0;
            Console.WriteLine("OPERADORES BITWISE");
            Console.Write("Digite o primeiro número inteiro: ");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o segundo número inteiro: ");
            int.TryParse(Console.ReadLine(), out op2);

            Console.WriteLine($"O valor de {op1} & {op2} = {op1&op2}");
            Console.WriteLine($"O valor de {op1} | {op2} = {op1|op2}");
            Console.WriteLine($"O valor de {op1} ^ {op2} = {op1^op2}");
            Console.WriteLine($"O valor de ~{op1} = {~op1}");
            Console.WriteLine($"O valor de {op1} << {op1 << op2}");
            Console.WriteLine($"O valor de {op1} >> {op1 >> op2}");

            Console.ReadKey();
        }
    }
}