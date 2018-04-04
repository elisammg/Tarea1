using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    public class Linea3D : LineaAbstracta<Punto3D>
    {
        public override Punto3D[] Puntos { get; }
        public Linea3D(Punto3D[] puntos)
        {
            this.Puntos = puntos;
        }

        public override double Distancia(Punto3D p1, Punto3D p2)
        {
            double dx = p1.X - p2.X;
            double dx2 = dx * dx;

            double dy = p1.Y - p2.Y;
            double dy2 = dy * dy;

            double dz = p1.Z - p2.Z;
            double dz2 = dz * dz;

            return Math.Sqrt(dx2 + dy2 + dz2);
        }
    }
}

