using System;

namespace M02Ex017
{
    class Program
    {
        public static void Main(string[] args)
        {
            float nota = 0;
            Console.Write("Digite a nota do aluno: ");
            float.TryParse(Console.ReadLine(), out nota);

            float validade = Math.Clamp(nota, 0, 10);

            Console.WriteLine($"A nota do aluno é {nota} e a nota validade é {validade}");
        }
    }
}