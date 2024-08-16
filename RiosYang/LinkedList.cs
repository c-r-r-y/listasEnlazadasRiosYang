using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiosYang
{
    internal class LinkedList
    {
        public Node inicio;
        public LinkedList()
        {
            inicio = null;
        }

        // EJERCICIO #1 - Metodo para insertar nodo al final de la lista
        public void insertarFinal(int item)
        {
            Node auxiliar = new Node();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Node puntero;
                puntero = inicio;

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }

                puntero.siguiente = auxiliar;
            }
        }

        // EJERCICIO #1 - Metodo para mostrar todos los elementos de la lista
        public void mostrarLista()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Node puntero;
                puntero = inicio;
                Console.WriteLine(puntero.dato);

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.WriteLine(puntero.dato);
                }

                Console.WriteLine();
            }
        }

        // EJERCICIO #2 - Metodo para eliminar nodo
        public void eliminarNodo(int item, int pos)
        {
            Node auxiliar = new Node();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                Console.WriteLine("La lista esta totalmente vacia");
                inicio = auxiliar;
            }
            else
            {
                Node puntero;
                puntero = inicio;
                if (pos == 1)
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else
                {

                }
            }
        }

        // EJERCICIO #3 - Metodo para encontrar el nodo medio de una lista
        
    }
}