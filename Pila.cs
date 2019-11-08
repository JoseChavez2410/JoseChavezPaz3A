using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberPilaCola.Clases
{
    class Pila
    {
        public void pila()
        {
            Stack stackpila = new Stack();
            int soporte = 0, opcion;
            string opcionaux;
            do
            {           
                Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                Console.WriteLine("\t   ♦        MENU TAD PILA       ♦");
                Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                Console.WriteLine("\t   ♦ 1.-Apilar                  ♦");
                Console.WriteLine("\t   ♦ 2.-Desapilar               ♦");
                Console.WriteLine("\t   ♦ 3.-Ver Cima                ♦");
                Console.WriteLine("\t   ♦ 4.-Salir                   ♦");
                Console.WriteLine("\t   ♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                Console.WriteLine("");
                Console.Write("Ingrese una opcion: ");
                opcionaux = Console.ReadLine();
                opcion = Convert.ToInt32(opcionaux);
                if (opcion == 1)
                {
                    Console.WriteLine("");
                    Console.Write("Ingrese un número: ");
                    stackpila.PilaPush(int.Parse(Console.ReadLine()));
                    Console.Clear();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine(stackpila.PilaPop());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine(stackpila.PilaPeek());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion==4)
                {
                    soporte = 1;
                    Console.Clear();
                    Console.WriteLine("Pila finalizada.");
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
