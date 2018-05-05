using ParseTree;
using System;
using Xunit;

namespace ParseTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void EvaluarTest()
        {
            ParseTree.ParseTree sut = new ParseTree.ParseTree("1+3*2+8");
            sut.Expandir();
            Assert.Equal(15, sut.Evaluar());
        }
    }
}
