using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_didactica_04_programacion3
{
    public class Chaqueta : Prenda
    {
        private string diseño;
        private string color;
        private string calidadTela;

        public Chaqueta(string diseño, string color, string calidad, string[] tallasDisponibles)
            : base("Chaqueta", calidad, tallasDisponibles)
        {
            this.diseño = diseño;
            this.color = color;
            this.calidad = calidad;
            this.tallasDisponibles = tallasDisponibles;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo de prenda: Chaqueta");
            Console.WriteLine("Diseño: {0}", diseño);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Calidad de tela: {0}", calidadTela);
            Console.WriteLine("Tallas disponibles:");
            foreach (string talla in tallasDisponibles)
            {
                Console.WriteLine("- " + talla);

            }
            Console.WriteLine();
        }
    }

}
