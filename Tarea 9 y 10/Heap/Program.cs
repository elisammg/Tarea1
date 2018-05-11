using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Program
    {
        public static int Heap;

        static void Main(string[] args)
        {
            
        }

        public static void HeapSort(int[] arreglo)
        {
            Heapify(arreglo);

            int temp;
            for (int i = arreglo.Length - 1; i > 0; i--)
            {
                temp = arreglo[i];
                arreglo[i] = arreglo[0];
                arreglo[0] = temp;

                ShiftDown(arreglo, 0, i);
            }
        }

		// i se refiere al indice actual
		public static void Heapify(int[] A)
		{
			Heap = A.Length - 1;

			for (int i = floop(A.Length); i >= 0; i--)
			{
				ShiftDown(A, i, A.Length - 1);
			}

		}

		public static void ShiftDown(int[] A, int i, int max)
		{
            
			int izq = Izquierdo(i);
			int der = Derecho(i);
           
			int index = 0;

			// Check to see which node in the tree subset has the largest value
			if (izq <= Heap && A[izq] > A[i] && izq < max)
			{
				index = izq;
			}
			else
			{
				index = i;
			}
			if (der <= Heap && A[der] > A[index] && der < max)
			{
				index = der;
			}

			// Do not make any switches if the largest node is the parent
			if (index != i)
			{
				int temp = A[index];
				A[index] = A[i];
				A[i] = temp;
				ShiftDown(A, index, max);
			}

		}

		private static int floop(int currentIndex)
		{
			return (currentIndex - 1)/ 2;
		}

		private static int Izquierdo(int currentIndex)
		{
			return currentIndex * 2 + 2;
		}

		private static int Derecho(int currentIndex)
		{
			return currentIndex * 2 + 1;
		}

	}
}
