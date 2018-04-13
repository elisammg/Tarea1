using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BinaryTree
{
    public class BinaryTree : IBinTree
    {
        public int Valor { get; set; }

        public IBinTree Derecho { get; set; }

        public IBinTree Izquierdo { get; set; }

        public BinaryTree(int valor, IBinTree derecho, IBinTree izquierdo)
        {
            this.Valor = valor;
            this.Derecho = derecho;
            this.Izquierdo = izquierdo;
        }

        public BinaryTree(int valor)
        {
            this.Valor = valor;
        }

        public override string ToString()
        {
            string derecho = this.Derecho == null ? string.Empty : this.Derecho.ToString();
            string izquierdo = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();
            return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
        }
       

       
        public int[] ToArray()
        {
            var comodin = new int[0];
            int[] resultado = new int[0];
            if (this.Izquierdo != null)

            {
                var ToArrIzq = Izquierdo.ToArray();
                resultado = ToArrIzq;
            }

            comodin = new int[resultado.Length + 1];
            resultado.CopyTo(comodin, 0);
            var ToArrValor = new int[] { this.Valor };
            ToArrValor.CopyTo(comodin, resultado.Length);
            resultado = comodin;

            if (this.Derecho != null)
            {
                var ToArrDer = Derecho.ToArray();
                comodin = new int[ToArrDer.Length + resultado.Length];
                resultado.CopyTo(comodin, 0);
                ToArrDer.CopyTo(comodin, resultado.Length);
            }

            resultado = comodin;

            return resultado;
        }

        public void Insert(int numero)
        {
            if (numero <= this.Valor)
            {
                if (Izquierdo == null)
                {
                    this.Izquierdo = new BinaryTree(numero);
                }
                else
                {
                    Izquierdo.Insert(numero);
                }
            }
            else
            {
                if (Derecho == null)
                    this.Derecho = new BinaryTree(numero);
                else
                    Derecho.Insert(numero);
            }
        }

        public int Sumar()
        {
            int sumaIzq = this.Izquierdo == null ? 0 : this.Izquierdo.Sumar();
            int sumaDer = this.Derecho == null ? 0 : this.Derecho.Sumar();

            return sumaDer + sumaIzq + this.Valor;
        }
    }
}

