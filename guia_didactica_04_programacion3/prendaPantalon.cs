using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_didactica_04_programacion3
{
    public class Pantalon : Prenda
    {
        private string corte;
        private string color;

        public Pantalon(string corte, string color, string calidad, string[] tallasDisponibles)
            : base("Pantalón", calidad, tallasDisponibles)
        {
            this.corte = corte;
            this.color = color;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo de prenda: {0}", tipo);
            Console.WriteLine("Corte: {0}", corte);
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
