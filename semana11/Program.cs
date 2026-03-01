using System;
using System.Collections.Generic;

class TraductorBidireccional
{
    static void Main()
    {
        // Diccionarios
        Dictionary<string, string> inglesEspanol = new Dictionary<string, string>()
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        // Diccionario inverso (Español → Inglés)
        Dictionary<string, string> espanolIngles = new Dictionary<string, string>();

        // Se llena automáticamente el diccionario inverso
        foreach (var item in inglesEspanol)
        {
            espanolIngles[item.Value] = item.Key;
        }

        int opcion;

        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir Inglés → Español");
            Console.WriteLine("2. Traducir Español → Inglés");
            Console.WriteLine("3. Agregar palabra");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    TraducirFrase(inglesEspanol);
                    break;

                case 2:
                    TraducirFrase(espanolIngles);
                    break;

                case 3:
                    Console.Write("Ingrese palabra en inglés: ");
                    string ing = Console.ReadLine().ToLower();

                    Console.Write("Ingrese palabra en español: ");
                    string esp = Console.ReadLine().ToLower();

                    if (!inglesEspanol.ContainsKey(ing))
                    {
                        inglesEspanol.Add(ing, esp);
                        espanolIngles.Add(esp, ing);
                        Console.WriteLine("Palabra agregada correctamente.\n");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ya existe.\n");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine().ToLower();

        string[] palabras = frase.Split(' ');
        string traduccion = "";

        foreach (string palabra in palabras)
        {
            string limpia = palabra.Replace(".", "")
                                   .Replace(",", "")
                                   .Replace(";", "")
                                   .Replace(":", "");

            if (diccionario.ContainsKey(limpia))
            {
                traduccion += diccionario[limpia] + " ";
            }
            else
            {
                traduccion += palabra + " ";
            }
        }

        Console.WriteLine("\nTraducción: " + traduccion + "\n");
    }
}