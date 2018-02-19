using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public interface IList<T>
    {
        bool Get(int indice);
        bool Set(int indice, T elemento);
        void Push(T elemento);
        int Lenght { get; }
    }
}
