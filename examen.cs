using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ciudades = { { 30, 50 }, { 34, 45 }, { 44, 60 }, { 36, 67 }, { 89, 46 }, { 98, 48 }, { 59, 32 } };
            string Nombre;
            Rutas ruta1 = new Rutas();
            int dife = 1;

            List<Rutas> ruta = new List<Rutas>()
            {
                new Rutas(){ Nombre = "Juan", Ciudad = 2, Colonia = 45},
                new Rutas(){ Nombre = "Pablo", Ciudad = 5, Colonia = 46 },
                new Rutas(){ Nombre = "Pedro", Ciudad = 3 , Colonia = 44},
                new Rutas(){ Nombre = "Yair", Ciudad = 4, Colonia = 67 },
                new Rutas(){ Nombre = "Yen", Ciudad = 1, Colonia = 50},
                new Rutas(){ Nombre = "jose", Ciudad = 5, Colonia = 89},
                new Rutas(){ Nombre = "Andres", Ciudad = 2, Colonia = 34 },
                new Rutas(){ Nombre = "pepe", Ciudad = 3, Colonia = 60},
                new Rutas(){ Nombre = "Daniel", Ciudad = 5, Colonia = 46},
                new Rutas(){ Nombre = "Dereck", Ciudad = 1, Colonia =  30},
                new Rutas(){ Nombre = "Zarabon", Ciudad = 4, Colonia = 67},
                new Rutas(){ Nombre = "Dodoria", Ciudad = 6, Colonia = 98},
                new Rutas(){ Nombre = "sara", Ciudad = 7, Colonia = 32},
                new Rutas(){ Nombre = "mariel", Ciudad = 6, Colonia = 48 },
                new Rutas(){ Nombre = "ximena", Ciudad = 2, Colonia = 45},
                new Rutas(){ Nombre = "angel", Ciudad = 5, Colonia = 46 },
                new Rutas(){ Nombre = "fabiola", Ciudad = 4 , Colonia = 67},
                new Rutas(){ Nombre = "ricardo", Ciudad = 4 , Colonia =36},
                new Rutas(){ Nombre = "Ana", Ciudad = 6, Colonia = 48},
                new Rutas(){ Nombre = "Luisa", Ciudad = 1, Colonia = 50 },
                new Rutas(){ Nombre = "Jimenes", Ciudad = 2, Colonia = 34},
                new Rutas(){ Nombre = "Cristopher", Ciudad = 4, Colonia = 36},
                new Rutas(){ Nombre = "Andrick", Ciudad = 7, Colonia = 32},
                new Rutas(){ Nombre = "Dilan", Ciudad = 6, Colonia = 48 },
                new Rutas(){ Nombre = "Axel", Ciudad = 7, Colonia = 59},
                new Rutas(){ Nombre = "Cristian", Ciudad = 1, Colonia = 50},
                new Rutas(){ Nombre = "Carmen", Ciudad = 3, Colonia = 44},
                new Rutas(){ Nombre = "Brayan", Ciudad = 4 , Colonia = 67},
                new Rutas(){ Nombre = "Brandon", Ciudad = 6, Colonia = 98},
                new Rutas(){ Nombre = "Francisco", Ciudad = 1, Colonia = 50 },
                new Rutas(){ Nombre = "Eder", Ciudad = 6, Colonia = 98},
            };
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("oooooooooooooo                        Nombre de los conductores                     ooooooooooooooooo");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("ooooooooo 1-Juan    7:Jose     13:mariel      19:Luisa         25:Axel              ooooooooooooooooo");
                Console.WriteLine("ooooooooo 2: Pablo  8:Pepe     14:ximena      20:Jimenes       26:Cristian          ooooooooooooooooo");
                Console.WriteLine("ooooooooo 3:Pedro   9:Andres   15:angel       21: Cristopher   27:Carmen            ooooooooooooooooo");
                Console.WriteLine("ooooooooo 4:Yair    10:Dereck  16:fabiola     22:Andrick       28:Brayan            ooooooooooooooooo");
                Console.WriteLine("ooooooooo 5:Yen     11:Zarabon 17: ricardo    23:Dilan         29:Brandon           ooooooooooooooooo");
                Console.WriteLine("ooooooooo 6:Daniel  12:sara    18:ana         24:Axel          30:Francisco         ooooooooooooooooo");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("De quien te gustaría consultar los datos de su viaje? (favor de introducir el nombre)");
                Nombre = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                ruta1.consultarDatos(ruta, Nombre, ciudades);
                Console.WriteLine("Quisieras consultar otros datos?\n1.Si.\n2.No.");
                dife = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (dife == 1);
            if (dife == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gracias por su visita!");
            }
            else
            {
                Console.WriteLine("Lo sentimos, ha ocurrido un error en el sistema, intentelo mas tarde.");
            }
        }
        public static void mostrarRutas(List<Rutas> ruta)
        {
            for (int i = 0; i < ruta.Count; i++)
            {
                Console.WriteLine(ruta[i].Nombre + " irá a la ciudad " + ruta[i].Ciudad + " en la colonia " + ruta[i].Colonia + ".");
            }
        }
    }
    public class Rutas
    {
        public string Nombre;
        public int Ciudad;
        public int Colonia;


        public void consultarDatos(List<Rutas> ruta, string nombre, int[,] vector)
        {
            bool bandera = false;
            int bandera2 = 0;
            double combustible, regular, premium;
            for (int i = 0; i < ruta.Count; i++)
            {
                if (ruta[i].Nombre == nombre)
                {
                    bandera2 = i;
                    bandera = true;
                }
            }
            if (bandera == true)
            {
                combustible = ((double)ruta[bandera2].Colonia * 0.16);
                regular = combustible * 21.326;
                premium = combustible * 23.302;
                Console.WriteLine("Conductor " + ruta[bandera2].Nombre + " llegará a la ciudad " + ruta[bandera2].Ciudad + " en la colonia " + ruta[bandera2].Colonia + ". \nLos kilometros que trendrá que recorrer serán " + ruta[bandera2].Colonia + ".\nTomando en cuenta que todos nuestros conductores usan autos que el equivalente de un kilometro es igual a 0.16 litros el combustible a gastar es: " + combustible + " litros.\nTambién tomando en cuenta que el litro de gasolina regular esta en 21.326 y el litro de premium esta en 23.302 el dinero a gastar si tuviera regular sería de: " + regular + " pesos. \nSi fuera premium sería de: " + premium + " pesos.");
            }
            else
            {
                Console.WriteLine("El nombre introducido no existe dentro de nuestras rutas.");
            }
        }
    }
}