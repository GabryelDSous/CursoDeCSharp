using System;

namespace M02Ex015
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<int> num = null; // O tipo int é não anulável
            int? num = null;

            int x = num ?? 99; // Operador de coalescência

            Console.WriteLine($"A variável tem valor nulo? {num is null}");
            Console.WriteLine($"A variável tem conteúdo? {num.HasValue}");

            Console.WriteLine($"A variável x recebeu o valor {x}");
        }
    }
}