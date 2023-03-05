using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_didactica_04_programacion3
{
    public abstract class Prenda
    {
        protected string tipo;
        protected string calidad;
        protected string[] tallasDisponibles;

        public Prenda(string tipo, string calidad, string[] tallasDisponibles)
        {
            this.tipo = tipo;
            this.calidad = calidad;
            this.tallasDisponibles = tallasDisponibles;
        }

        public abstract void MostrarInformacion();
    }
}
