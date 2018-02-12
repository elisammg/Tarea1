using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public enum Estado
    {
        EnProceso,
        Finalizado
    }

    public class QueHacer
    {
        public string Descripcion { get; set; }
        public String Lugar { get; set; }
        public DateTime Hora { get; set; }
        public Estado Estado { get; private set; }

        public QueHacer(string descripcion, string lugar, DateTime hora)
        {
            this.Descripcion = descripcion;
            this.Lugar = lugar;
            this.Hora = hora;
            this.Estado = new Estado();
            this.Estado = Estado.EnProceso;
        }

        public void Completar()
        {
            this.Estado = Estado.Finalizado;
        }
    }
}
