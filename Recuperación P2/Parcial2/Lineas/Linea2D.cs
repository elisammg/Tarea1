using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    public class Linea2D : LineaAbstracta<Punto2D>

    {

        public override Punto2D[] Puntos { get; }
        public Linea2D(Punto2D[] puntos)
        {
            this.Puntos = puntos;
        }

        public override double Distancia(Punto2D p1, Punto2D p2)
        {
            double dx = p1.X - p2.X;
            double dx2 = dx * dx;

            double dy = p1.Y - p2.Y;
            double dy2 = dy * dy;

            return Math.Sqrt(dx2 + dy2);
        }
    }
}

