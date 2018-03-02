using System;

namespace Reduce
{
   public class Program
    {
        public static int ReduceInt(int [] primerParametro, int acumulador, Func<int, int, int> resultado)
        {
                for (int i=0; i < primerParametro.Length; i++)
                {
                    acumulador = resultado(acumulador, primerParametro[i]);
                }
                return acumulador;
        }

        public static T Reduce<U, T>(U[] primerParametro, T acumulador, Func<T, U, T> resultado)
        {
            for (int i = 0; i < primerParametro.Length; i++)
            {
                acumulador = resultado(acumulador, primerParametro[i]);
            }

            return acumulador;

        }



    }
}
