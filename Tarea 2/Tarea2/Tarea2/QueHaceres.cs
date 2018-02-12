using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
   public class QueHaceres
    {
        public List<QueHacer> ListaTareas { get; set; }

        public QueHaceres()
        {
            ListaTareas = new List<QueHacer>();
        }

        public void NuevaTarea (QueHacer QueHacer)
        {
            ListaTareas.Add(QueHacer);
        }

        public void TerminarQueHacer ()
        {
            for (int i = 0; i < ListaTareas.Count; i++)
            {
                if (ListaTareas[i].Estado == Estado.EnProceso)
                {
                    ListaTareas[i].Completar();
                    break;
                }
            }
        }

        public bool EstaDisponible()
        {
            for (int i = 0; i < ListaTareas.Count; i++)
            {
                if (ListaTareas[i].Estado == Estado.EnProceso)
                {
                    return false;
                }
              
            }
            return true;
        }
    }
}
