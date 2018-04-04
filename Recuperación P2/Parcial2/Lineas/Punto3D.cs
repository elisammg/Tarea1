using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    public class Punto3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Punto3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }
    }
}
