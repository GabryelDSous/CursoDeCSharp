using System;

namespace M02Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = false;
            bool q = false;
            Console.WriteLine($"Não {p} = {!p}"); // Oerador Logico NÃO
            Console.WriteLine($"{p} e {q} = {p&&q}"); // OpL E
            Console.WriteLine($"{p} ou {q} = {p||q}"); // OpL OU

            Console.ReadKey();
        }
    }
}