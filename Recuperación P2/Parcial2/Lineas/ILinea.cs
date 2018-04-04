using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    public interface ILinea <T>
    {
        double Longitud();

        T Puntomascerano(T punto);
    }
}
