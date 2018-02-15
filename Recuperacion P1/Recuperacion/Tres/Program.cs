using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tres
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1 = "";
            string palabra2 = "";

            Console.WriteLine("Escribe una palabra o frase: ");
            palabra1 = Console.ReadLine();
            palabra1 = palabra1.Replace(" ", String.Empty);

            for (int i = palabra1.Length - 1; i >= 0; i--)
            {
                palabra2 += palabra1[i];
            }

            if (palabra1.Equals(palabra2))
                Console.WriteLine("Es palindromo");
            else
                Console.WriteLine("No es palindromo");
            Console.ReadLine();
        }
    }
}
