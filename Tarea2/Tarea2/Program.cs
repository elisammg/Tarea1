using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        { 
                QueHacer QueHacer1 = new QueHacer("Hacer almuerzo", "Cocina", new DateTime());
                QueHacer QueHacer2 = new QueHacer("Lavar platos", "Cocina", new DateTime());
                QueHacer QueHacer3 = new QueHacer("Estudiar para examen", "cuarto de estudio", new DateTime());
                QueHacer QueHacer4 = new QueHacer("Hacer la cama", "Cuarto", new DateTime());
                QueHacer QueHacer5 = new QueHacer("Lavar ropa", "lavandería", new DateTime());
                QueHacer QueHacer6 = new QueHacer("Cepillar los dientes", "baño", new DateTime());

                Persona Persona1 = new Persona();
                Persona1.NuevoQueHacer(QueHacer2);
                Persona1.NuevoQueHacer(QueHacer3);
                Persona1.NuevoQueHacer(QueHacer5);

                Persona Persona2 = new Persona();
                Persona2.NuevoQueHacer(QueHacer1);
                Persona2.NuevoQueHacer(QueHacer4);
                Persona2.NuevoQueHacer(QueHacer6);

                Persona1.TerminarQueHacer();

                Persona2.TerminarQueHacer();
                Persona2.TerminarQueHacer();
                Persona2.TerminarQueHacer();

                Console.WriteLine("La persona uno esta disponible? {0}", Persona1.EstaDisponible());
                Console.WriteLine("La persona dos esta disponible? {0}", Persona2.EstaDisponible());

                Console.ReadLine();
            
        }
    }
}
