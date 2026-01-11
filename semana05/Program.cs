using System;
using System.Collections.Generic;
using System.Linq;

namespace DeberListasTuplas
{
    // ===== EJERCICIO 1 Y 2 =====
    class Curso
    {
        public List<string> Asignaturas { get; set; } = new List<string>();

        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (var a in Asignaturas)
                Console.WriteLine("- " + a);
        }

        public void MostrarEstudio()
        {
            foreach (var a in Asignaturas)
                Console.WriteLine($"Yo estudio {a}");
        }
    }

    // ===== EJERCICIO 4 =====
    class Loteria
    {
        public List<int> Numeros { get; set; } = new List<int>();

        public void Ejecutar()
        {
            Console.WriteLine("Ingrese 6 números ganadores:");
            while (Numeros.Count < 6)
            {
                Console.Write("Número: ");
                if (int.TryParse(Console.ReadLine(), out int n))
                    Numeros.Add(n);
            }

            Numeros.Sort();
            Console.WriteLine("Números ordenados:");
            Console.WriteLine(string.Join(", ", Numeros));
        }
    }

    // ===== EJERCICIO 5 =====
    class Secuencia
    {
        public void MostrarInverso()
        {
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 10; i++)
                numeros.Add(i);

            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                Console.Write(numeros[i]);
                if (i > 0) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }

    // ===== EJERCICIO 10 =====
    class Precios
    {
        public List<int> Lista { get; set; } = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

        public void MostrarMayorMenor()
        {
            Console.WriteLine($"Precio menor: {Lista.Min()}");
            Console.WriteLine($"Precio mayor: {Lista.Max()}");
        }
    }

    // ===== PROGRAMA PRINCIPAL =====
    class Program
    {
        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== DEBER LISTAS Y TUPLAS (C#) =====");
                Console.WriteLine("1. Ejercicio 1 - Mostrar asignaturas");
                Console.WriteLine("2. Ejercicio 2 - Yo estudio...");
                Console.WriteLine("3. Ejercicio 4 - Lotería");
                Console.WriteLine("4. Ejercicio 5 - Números inversos");
                Console.WriteLine("5. Ejercicio 10 - Precio mayor y menor");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("=== EJERCICIO 1 ===");
                        Curso c1 = new Curso();
                        c1.Asignaturas.AddRange(new[] { "Matemáticas", "Física", "Química", "Historia", "Lengua" });
                        c1.MostrarAsignaturas();
                        break;

                    case 2:
                        Console.WriteLine("=== EJERCICIO 2 ===");
                        Curso c2 = new Curso();
                        c2.Asignaturas.AddRange(new[] { "Matemáticas", "Física", "Química", "Historia", "Lengua" });
                        c2.MostrarEstudio();
                        break;

                    case 3:
                        Console.WriteLine("=== EJERCICIO 4 ===");
                        Loteria loteria = new Loteria();
                        loteria.Ejecutar();
                        break;

                    case 4:
                        Console.WriteLine("=== EJERCICIO 5 ===");
                        Secuencia sec = new Secuencia();
                        sec.MostrarInverso();
                        break;

                    case 5:
                        Console.WriteLine("=== EJERCICIO 10 ===");
                        Precios p = new Precios();
                        p.MostrarMayorMenor();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
