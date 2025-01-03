﻿using System;

namespace M02Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0f;
            float nota2 = 0f;

            Console.Write("Primeira nota: ");
            float.TryParse(Console.ReadLine(), out nota1);
            Console.Write("Segunda nota: ");
            float.TryParse(Console.ReadLine(), out nota2);

            float média = (nota1 + nota2) / 2;
            Console.WriteLine($"As notas registradas foram {nota1:F1} e {nota2:F1}");
            Console.WriteLine($"A médiado aluno foi {média:F1}");
            Console.ReadKey();
        }
    }
}