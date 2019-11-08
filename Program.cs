using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeberPilaCola.Clases;

namespace DeberPilaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola PCola = new Cola();
            Pila PPila = new Pila();

            int soporte = 0, opcion;           
            string opcionaux;
            do
            {          
            Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("\t   ♦        MENU PRINCIPAL       ♦");
            Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("\t   ♦           1.-Pila           ♦");
            Console.WriteLine("\t   ♦           2.-Cola           ♦");
            Console.WriteLine("\t   ♦           3.-Salir          ♦");
            Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("");
            Console.Write("Ingrese la opcion a ejecutar (1/2/3): ");
                opcionaux = Console.ReadLine();
                opcion = Convert.ToInt32(opcionaux);
                if (opcion==1)
                {
                    Console.Clear();
                    PPila.pila();                   
                }
                else if (opcion==2)
                {
                    Console.Clear();
                    PCola.cola();
                }
                else if (opcion==3)
                {
                    soporte = 1;
                    Console.Clear();
                    Console.WriteLine("Programa finalizado.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                }                
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR.");
                    Console.WriteLine("Por favor, ingrese una opcion valida (1/2/3).");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (soporte==0);
        }
    }
}
