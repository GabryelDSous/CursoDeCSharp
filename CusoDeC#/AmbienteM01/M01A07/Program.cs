using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversão Implícita int -> float
            /*
                int a = 8;
                float b = a; 
            */

            //Conversão Explícita float -> int
            /*
                float a = 8.9999f;
                int b = (int) a; // Dá erro por causa do tipo (Um número inteiro cabe dentro de um float, mas um float não cabe dentro de um 
            */

            // Conversão por Classes Auxíliares
            float a = 8.5001f;
            int b = Convert.ToInt16(a);

            Console.WriteLine("O valor de a é "+ a +" do tipo "+ a.GetType());
            Console.WriteLine("O valor d b é "+ b +" do tipo "+ b.GetType());
        }
    }
}
