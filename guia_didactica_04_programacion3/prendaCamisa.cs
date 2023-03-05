using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_didactica_04_programacion3
{
    public class Camisa : Prenda
    {
        private string diseno;
        private string color;

        public Camisa(string diseno, string color, string calidad, string[] tallasDisponibles)
            : base("Camisa", calidad, tallasDisponibles)
        {
            this.diseno = diseno;
            this.color = color;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo de prenda: {0}", tipo);
            Console.WriteLine("Diseño: {0}", diseno);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Calidad de tela: {0}", calidad);
            Console.WriteLine("Tallas disponibles:");
            foreach (string talla in tallasDisponibles)
            {
                Console.WriteLine("- {0}", talla);
            }
            Console.WriteLine();
        }
    }
}
