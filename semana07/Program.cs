using System;
using System.Collections.Generic;

class PilasEjercicios
{
    static void Main()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("EJERCICIO 1: PARÉNTESIS BALANCEADOS");
        Console.WriteLine("======================================");

        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");

        Console.WriteLine("\n======================================");
        Console.WriteLine("EJERCICIO 2: TORRES DE HANOI");
        Console.WriteLine("======================================");

        int discos = 3;

        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        for (int i = discos; i >= 1; i--)
        {
            origen.Push(i);
        }

        ResolverHanoi(discos, origen, destino, auxiliar, "A", "C", "B");
    }

    // ============================
    // EJERCICIO 1: PARÉNTESIS
    // ============================
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char ultimo = pila.Pop();

                if (!EsPar(ultimo, c))
                    return false;
            }
        }

        return pila.Count == 0;
    }

    static bool EsPar(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    // ============================
    // EJERCICIO 2: TORRES DE HANOI
    // ============================
    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                              string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de Torre {nombreOrigen} a Torre {nombreDestino}");
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino,
                      nombreOrigen, nombreAuxiliar, nombreDestino);

        int discoActual = origen.Pop();
        destino.Push(discoActual);
        Console.WriteLine($"Mover disco {discoActual} de Torre {nombreOrigen} a Torre {nombreDestino}");

        ResolverHanoi(n - 1, auxiliar, destino, origen,
                      nombreAuxiliar, nombreDestino, nombreOrigen);
    }
}

