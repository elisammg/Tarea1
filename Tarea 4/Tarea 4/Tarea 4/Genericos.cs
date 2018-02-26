using System;
using System.Collections.Generic;
using System.Text;

namespace Genericos
{
    public class Genericos
    {
        public Genericos() { }

        public static T Head<T>(T[] arreglo)
        {
            return arreglo[0];
        }

        public T[] Tail<T>(T[] arreglo)
        {
            T[] nuevoArreglo = new T[arreglo.Length - 1];
            int espacio = 0;
            for (int i = 1; i < arreglo.Length; i++)
            {
                nuevoArreglo[espacio] = arreglo[i];
                espacio += 1;
            }
            return nuevoArreglo;
        }

        public class Tupla<T1, T2> 
        {
            public T1 Primero { get; }
            public T2 Segundo { get; }

            public Tupla(T1 primero, T2 segundo)
            {
                this.Primero = primero;
                this.Segundo = segundo;
            }
        }


       
    }
    
}
