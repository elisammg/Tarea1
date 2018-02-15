using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1 = "";
            string palabra2 = "";

            Console.WriteLine("Escribe una palabra o frase: ");
            palabra1 = Console.ReadLine();

            for (int i = palabra1.Length -1; i >=0; i-- )
            {
                palabra2 += palabra1[i];
            }

            Console.WriteLine("Palabra Invertida: " + palabra2);
            Console.ReadLine();
        }
    }
}
