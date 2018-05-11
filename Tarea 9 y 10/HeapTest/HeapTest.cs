using Heap;
using System;
using Xunit;

namespace HeapTest
{
    public class HeapTest
    {
        [Fact]
        public void HeapfyTest()
        {
            int[] arreglo = { 2, 5, 6, 4, 20, 12 };
            Program.Heapify(arreglo);
            Assert.Equal(20, arreglo[0]);
        }

        [Fact] 
        public void HeapSortTest()
        {
            int[] arreglo = { 2, 5, 6, 4, 20, 80, 1, 1065, 12 };
            Program.HeapSort(arreglo);
            Assert.Equal(new int[] { 1, 2, 4, 5, 6, 12, 20, 80, 1065 }, arreglo);
        }
	}
}
