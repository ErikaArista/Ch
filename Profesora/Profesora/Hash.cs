using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesora
{
    public class Hash
    {
        Hashtable tabla;

        public Hash()
        {
            tabla = new Hashtable();
        }
        public void menu()
        {
            Console.WriteLine("----BIENVENIDO A LA FRUTERIA HASH----\n");
            int cont = 0;
            while (cont != 1)
            {
                Console.WriteLine("Que operacion desea realizar: \n 1.Agregar Fruta \n 2.Buscar Fruta \n 3.Eliminar Fruta \n 4.Salir");
                Console.WriteLine("Elija la opcion");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Agregar();
                        break;

                    case "2":
                        Buscar();
                        break;
                    case "3":
                        Eliminar();
                        break;
                    case "4":
                        cont = 1;
                        break;
                }
            }
        }
        public void Agregar()
        {
            int cont = 0;
            while (cont != 1)
            {
                Console.WriteLine("Quiere agregar una fruta si/no: ");
                string pregunta = Console.ReadLine();

                if (pregunta == "si")
                {
                    
                    Console.WriteLine("Ingrese la clave de la fruta que desea agregar: ");
                    string clave = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de la fruta: ");
                    string fruit = Console.ReadLine();
                    tabla.Add(clave, fruit);
                    Console.WriteLine("CLAVE: " + clave + " y FRUTA: " + fruit + " fueron agregadas correctamente");
                   
                    
                    
                }
                else
                {
                    cont = 1;
                    Console.WriteLine("Por el momento hay {0} frutas ", tabla.Count);
                    Console.WriteLine("\n Regresara al menu");
                    menu();
                }
            }

        }
        public void Buscar()
        {
            int cont = 0;
            while (cont != 1)
            {
                Console.WriteLine("Quiere buscar una fruta si/no: ");
                string bus = Console.ReadLine();
                if (bus == "si") {
                    Console.WriteLine("Dame la clave de la fruta que quieres buscar: ");
                    string fruta = Console.ReadLine();

                    if (tabla[fruta] == null)
                    {
                        Console.WriteLine("Clave no encontrada");
                     
                    }
                    else
                    {
                        cont = 1;
                        Console.WriteLine("La clave encontradoa es: ");
                        Console.WriteLine(tabla[fruta]);
                        
                    }
                }
                else
                {
                    cont = 1;
                    Console.WriteLine("\n Regresara al menu");
                    menu();
                }
            }
            
        }
        public void Eliminar()
        {
            int cont = 0;
            while (cont != 1)
            {
                Console.WriteLine("Quiere eliminar una fruta si/no: ");
                string bus = Console.ReadLine();
                if (bus == "si")
                {
                    Console.WriteLine("Que clave desea eliminar: ");
                    string clave = Console.ReadLine();
                    if (tabla[clave] == null)
                    {
                        Console.WriteLine("Clave no encontrada");
                    }
                    else
                    {
                        tabla.Remove(clave);
                        Console.WriteLine("Clave: " + clave + " eliminada");
                        Console.WriteLine("Por el momento hay {0} frutas ", tabla.Count);
                     
                    }
                }
                else
                {
                    cont = 1;
                    Console.WriteLine("\n Regresara al menu");
                    menu();
                }
                Console.ReadKey();
            }
        }
    }
}
