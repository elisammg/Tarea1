using System;
using System.Collections.Generic;
using System.Text;

namespace ParseTree
{
    public class ParseTree : BinaryTree<string>
    {
        public ParseTree(string valor, IBinTree<string> derecho, IBinTree<string> izquierdo) : base(valor, derecho, izquierdo)
        {

        }

        public ParseTree(string valor) : base(valor)
        {
            this.Valor = valor;
        }

        public override void ExpandirSuma()
        {

            int lastSuma = Valor.LastIndexOf("+");

            if (lastSuma == -1)
                return;

            this.Izquierdo = new ParseTree(Valor.Substring(0, lastSuma));
            this.Derecho = new ParseTree(Valor.Substring(lastSuma + 1, Valor.Length - lastSuma - 1));

            this.Valor = "+";

            this.Izquierdo.Expandir();
            this.Derecho.Expandir();
        }

        public override void ExpandirMultiplicacion()
        {

            int lastSuma = Valor.LastIndexOf("*");

            if (lastSuma == -1)
                return;

            this.Izquierdo = new ParseTree(Valor.Substring(0, lastSuma));
            this.Derecho = new ParseTree(Valor.Substring(lastSuma + 1, Valor.Length - lastSuma - 1));

            this.Valor = "*";

            this.Izquierdo.Expandir();
            this.Derecho.Expandir();
        }

        public override void Expandir()
        {
            ExpandirSuma();
            ExpandirMultiplicacion();
        }

        public override int Evaluar()
        {
            switch (Valor)
            {
                case "+":
                    return Izquierdo.Evaluar() + Derecho.Evaluar();
                case "*":
                    return Izquierdo.Evaluar() * Derecho.Evaluar();
            }

            return Int32.Parse(Valor);
        }

    }
}
