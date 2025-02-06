using System;

namespace M02Ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            int lotacao = 10;
            int tot = 4;

            int grupo = 0;
            Console.Write("Quantas pessoas chegaram? ");
            int.TryParse(Console.ReadLine(), out grupo);
            tot += grupo; // Mesma coisa que total = total + grupo
            Console.WriteLine($"Chegando um grupo de {grupo} pessoas, agora temos {tot} pessoas na festa");
            Console.WriteLine($"Lotou a balada? {tot >= lotacao}");
        }
    }
}