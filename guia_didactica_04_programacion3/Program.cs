using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_didactica_04_programacion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camisa camisa1 = new Camisa("Rayas", "Azul", "Alta", new string[] { "S", "M", "L" });
            Camisa camisa2 = new Camisa("Cuadriculada", "Roja con blanco", "Alta", new string[] { "S", "M", "L" });
            Camisa camisa3 = new Camisa("Un solo fondo", "Gris", "Media", new string[] { "S", "M", "L" });
            Camisa camisa4 = new Camisa("Manga Larga", "Azul claro", "Alta", new string[] { "S", "M", "L" });

            Pantalon pantalon1 = new Pantalon("Skinny", "Negro", "Media", new string[] { "28", "30", "32", "34" });
            Pantalon pantalon2 = new Pantalon("Recto", "Gris", "Baja", new string[] { "30", "32", "34", "36" });
            Pantalon pantalon3 = new Pantalon("Drop Crotch", "Negro", "Media", new string[] { "28", "30", "32", "34" });
            Pantalon pantalon4 = new Pantalon("Slim Fit", "Gris", "Baja", new string[] { "30", "32", "34", "36" });

            Chaqueta chaqueta1 = new Chaqueta("Jeans", "Azul", "Alta", new string[] { "S", "M", "L" });
            Chaqueta chaqueta2 = new Chaqueta("Impermeable", "Negra", "Baja", new string[] { "S", "M", "L" });

            camisa1.MostrarInformacion();
            camisa2.MostrarInformacion();
            camisa3.MostrarInformacion();
            camisa4.MostrarInformacion();

            pantalon1.MostrarInformacion();
            pantalon2.MostrarInformacion();
            pantalon3.MostrarInformacion();
            pantalon4.MostrarInformacion();

            chaqueta1.MostrarInformacion();
            chaqueta2.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
