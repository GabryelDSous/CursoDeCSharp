using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("SORTEADOR DE NÚMERO");
            Console.WriteLine("------------------------------");
            Console.Write("Inicio: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fim: ");
            int fim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");
            // Exibe "Sorteando..." na mesma linha
            Console.Write("Sorteando...");
            Thread.Sleep(2000); // Aguarda 2 segundos

            // Gera o número aleatório
            Random random = new Random();
            int numeroSorteado = random.Next(inicio, fim + 1);

            // Sobrescreve a linha com o número sorteado
            Console.Write("\rNúmero sorteado: " + numeroSorteado);

            Console.ReadKey();
        }
    }
}
