using System;

namespace ListasEnlazadas
{
    // Clase Nodo
    class Nodo
    {
        public int Dato;
        public Nodo Siguiente;

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase Lista Enlazada
    class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Insertar al final
        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // EJERCICIO 1: Contar elementos de la lista
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // EJERCICIO 2: Invertir la lista enlazada
        public void InvertirLista()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            cabeza = anterior;
        }

        // Mostrar lista
        public void Mostrar()
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Insertar datos
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(30);
            lista.Insertar(40);
            lista.Insertar(50);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            // Contar elementos
            Console.WriteLine("\nNúmero de elementos en la lista: " + lista.ContarElementos());

            // Invertir lista
            lista.InvertirLista();
            Console.WriteLine("\nLista invertida:");
            lista.Mostrar();

            Console.ReadKey();
        }
    }
}
