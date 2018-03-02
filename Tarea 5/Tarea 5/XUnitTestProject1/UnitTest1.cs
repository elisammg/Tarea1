using System;
using Xunit;

namespace ReduceTest

{
    public class UnitTest1
    {
        [Fact]
        public void TestReduce()
        {
           
                int[] valores = new int[] { 0, 1, 2, 3 };
                Assert.AreEqual(Program.ReduceInt(valores, 0, (acumulador, valor) => acumulador + valor), 6);
            
        }
        [Fact]
        public void TestReduceGenericos()
        {
           
                string[] valores = new string[] { "hola", "como", "estas" };
                Assert.AreEqual(Program.Reduce<string, int>(valores, 0, (acumulador, valor) => acumulador + valor.Length), 13);
            
        }

    }
}
