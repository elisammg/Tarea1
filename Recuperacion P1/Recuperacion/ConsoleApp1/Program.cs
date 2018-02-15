using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string palabra1;
                string palabra2;
                Console.Write("Ingrese una palabra o frase: ");
                palabra1 = Console.ReadLine();
                if (palabra1.Length == 0)
                    break;
                else
                {
                    Console.Write("Ingrese otra palabra o frase: ");
                    palabra2 = Console.ReadLine();
                    if (SonAnagramas(palabra1, palabra2) == false)
                    {
                        Console.Write("No es anagramas.");
                        break;
                    }
                    else
                    {
                        Console.Write("Es anagramas.");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
        public static bool SonAnagramas(string primera, string segunda)
        {
            int contador1, contador2;
            if (primera.Length == segunda.Length)
            {
                for (int i = 0; i < primera.Length; i++)
                {
                    contador1 = 0;
                    contador2 = 0;
                    for (int j = 0; j < segunda.Length; j++)
                    {
                        if (primera[i] == segunda[j])
                            contador1++;
                        if (segunda[i] == primera[j])
                            contador1++;
                    }
                    if (contador1 != contador2)
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
