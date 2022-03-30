using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Tipos2
    {
        class program2
        {
            static void Main(string[] args)
            {
                Animales1 Terrestre = new Animales1("4.0 metros", "6.350 kilogramos", "Gris");
                Console.WriteLine("Este animal es una elefante: " + Terrestre);
                Animales1 Terrestre2 = new Animales1("2.5 metros", "250 kilogramos", "Amarilloa");
                Console.WriteLine("Este es un sapo europeo: " + Terrestre2);
            }
        }
    }
}
