using System;
using Xunit;

namespace GenericosTest
{
    public class GenericosTest
    {
        [Fact]
        public void HeadTest()
        {
            int[] arreglo = { 0, 1, 2, 3};
            Genericos generico = new Genericos();
            int valor = generico.Head<int>(arreglo);
            Assert.AreEqual(valor, arreglo[0]);
        }

        [Fact]
        public void TailTest()
        {
            int[] ArregloBase = { 10, 20, 30, 40 };
            Genericos generico = new Generico();
            int[] NuevoArreglo = genericos.Tail<int>(ArregloBase);
            Assert.AreEqual(ArregloBase[0], NuevoArreglo[0]);
        }

        [Fact]
        public void TuplaTest()
        {

        }
    }
}
