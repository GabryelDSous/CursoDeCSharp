using System;
namespace NumerosAleatorios
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int numRandom = random.Next(1, 101);
            int numLido = 0;
            int tentativas = 0;
            Console.WriteLine("Estou pensando em um número, tente adivinhar [1-100]");
            Console.Write("Qual seu palpite: ");
            while(numLido != numRandom)
            {
                tentativas++;
                int.TryParse(Console.ReadLine(), out numLido);
                if(numLido < 1 || numLido > 100)
                {
                    Console.WriteLine("O número deve estar entre 1 e 100");
                } else if(numLido < numRandom)
                {
                    Console.WriteLine("Muito baixo! Tente novamente");
                } else if(numLido > numRandom)
                {
                    Console.WriteLine("Muito alto! Tente novamente");
                } else
                {
                    break;
                }
            }
            Console.WriteLine($"Parábens, você acertou em {tentativas} tentativas");
            Console.ReadKey();
        }
    }
}