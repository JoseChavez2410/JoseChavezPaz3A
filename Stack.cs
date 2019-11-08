using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberPilaCola.Clases
{
    public class Stack
    {
        private CNodo ancla;
        private CNodo trabajo; 

        public Stack()
        {
            ancla = new CNodo();
            ancla.Siguiente = null;
        }
        public void PilaPush(int pDato)
        {
            CNodo datoaux = new CNodo();
            datoaux.Dato = pDato;
            datoaux.Siguiente = ancla.Siguiente;
            ancla.Siguiente = datoaux;
        }

        public int PilaPop()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
                Console.Write("Desapilado: ");
            }
            if (valor == 0)
            {
                Console.WriteLine("La Pila está vacia.");
            }            
            return valor;
        }

        public int PilaPeek()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
                Console.Write("Cima: ");
            }
            if (valor==0)
            {
                Console.WriteLine("La Pila está vacia.");
            }
            return valor;
        }

        public void PilaTransversa()
        {
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                int elemento = trabajo.Dato;
                Console.WriteLine("{[0]}", elemento);
            }
        }
    }
}
