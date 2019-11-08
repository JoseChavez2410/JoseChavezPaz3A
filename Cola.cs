using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberPilaCola.Clases
{
    class Cola
    {
        public void cola()
        {
            OpsCola cola = new OpsCola();
            int soporte = 0, opcion;
            string opcionaux;
            do
            {
                Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                Console.WriteLine("\t   ♦        MENU TAD COLA       ♦");
                Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                Console.WriteLine("\t   ♦ 1.-Insertar elemento       ♦");
                Console.WriteLine("\t   ♦ 2.-Recorrer cola           ♦");
                Console.WriteLine("\t   ♦ 3.-Salir                   ♦");
                Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                Console.WriteLine("");
                Console.Write("Ingrese una opción: ");
                opcionaux = Console.ReadLine();
                opcion = Convert.ToInt32(opcionaux);
                if (opcion == 1)
                {
                    cola.InsertarElemento();
                    Console.Clear();
                }
                else if (opcion == 2)
                {
                    cola.RecorrerCola();
                    Console.Clear();
                }
                else if (opcion == 3)
                {
                    soporte = 1;
                    Console.Clear();
                    Console.WriteLine("Cola finalizada.");
                    Console.WriteLine("Presione cualquier tecla para volver al menu principal.");
                    Console.ReadKey();
                    Console.Clear();
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
