using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Tipo3
    {
        class program3
        {
            static void Main(string[] args)
            {
                Animales1 Voladores = new Animales1("4.0 metros", "6.350 kilogramos", "Gris");
                Console.WriteLine("Este animal es una elefante: " + Voladores);
                Animales1 Voladores2 = new Animales1("10  mm", "Dato no especifico", "Rojo con negro");
                Console.WriteLine("Este es un sapo europeo: " + Voladores2);
            }
        }
    }
}
