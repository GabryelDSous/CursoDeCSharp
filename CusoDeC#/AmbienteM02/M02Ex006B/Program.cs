using System;
namespace M02Ex006B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando variaveis
            int ANO = DateTime.Now.Year;
            int NascANO;
            int IDADE;

            // Entrada de dados
            Console.Write("Qual em que ano você nasceu? ");
            int.TryParse(Console.ReadLine(), out NascANO);
            IDADE = ANO - NascANO;
            Console.WriteLine($"Você tem {IDADE} anos");
            // Saída de dodos
            Console.WriteLine($"Não pode votar {IDADE>=0 && IDADE<16}"); // Menor de 16 anos
            Console.WriteLine($"Voto Opcional {IDADE>=16 && IDADE <= 17|| IDADE>64}"); // Idade entre 16 e 17 ou maior igual a 65 anos
            Console.WriteLine($"Voto Obrigatorio {IDADE>=18 && IDADE <=64}"); // Idade entre 18 e 64 
        }
    }
}