using System;

namespace M02Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de operadores aritméticos
            int op1;
            int op2;
            // Entrada de dados
            Console.Write("Digite o primeiro operando: ");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o segundo operando: ");
            int.TryParse(Console.ReadLine(), out op2);
            // Realizando as operações
            Console.WriteLine($"Calculando +{op1} = {+op1}"); // identidade
            Console.WriteLine($"Calculando -{op1} = {-op1}"); // negação aritmética
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}"); //  adição
            Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}"); // subtração
            Console.WriteLine($"Calculando {op1} x {op2} = {op1 * op2}"); // multiplicação
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {op1 / op2} (divisão inteira)"); // divisão (inteira)
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {(float)op1 / op2} (divisão real)"); // divisão (real)
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1%op2}"); // resto da divisão
            Console.ReadKey();
        }
    }
}