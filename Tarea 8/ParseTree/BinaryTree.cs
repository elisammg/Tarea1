using System;
using System.Linq;

public abstract class BinaryTree<U> : IBinTree<U>{
    public U Valor {get; set;}

    public IBinTree<U> Derecho { get; set; }

    public IBinTree<U> Izquierdo { get; set; }
   
    public BinaryTree(U valor, IBinTree<U> derecho, IBinTree<U> izquierdo){
        this.Valor = valor;
        this.Derecho = derecho;
        this.Izquierdo = izquierdo;
    }

    public BinaryTree(U valor){
        this.Valor = valor;
    }

    public override string ToString(){
        string derecho = this.Derecho == null ? string.Empty : this.Derecho.ToString();
        string izquierdo = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();
        return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
    }
    public T Reduce<T>(T inicial, Func<T, T, U, T> fn)
    {
        T izquierdo = inicial; //this.Izquierdo == null ? inicial : this.Izquierdo.Reduce<T>(inicial, fn);
        T derecho = inicial; //this.Derecho == null ?  inicial : this.Derecho.Reduce<T>(inicial, fn);

        return fn(izquierdo, derecho, this.Valor);
    }

    public U[] ToArray()
    {
        return this.Reduce<U[]>(new U[]{}, (izquierdo, derecho, valor) => {
            return izquierdo.Concat(new U[]{valor}).Concat(derecho).ToArray();
        });
    }

    public static int[] Concatenar(int[] a, int[] b)
    {
        int[] resultado = new int[a.Length + b.Length];
        int final = 0;

        for(int i = 0; i < a.Length; i++)
        {
            resultado[i] = a[i];
            final = i;
        }

        for(int j = 0; j < b.Length; j++)
        {
            resultado[a.Length - 1 + j] = b[j];
        }

        return resultado;
    }

    public abstract void ExpandirSuma();

    public abstract void ExpandirMultiplicacion();

    public abstract void Expandir();

    public abstract int Evaluar();
}